using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

public class EnemySystem : MonoBehaviour {

	public bool updateList = true;
	public Vector3 area;

	Vector3 center;

	Enemy[] enemies;
	Attractor[] attractors;

	System.Random random = new System.Random();
	ThreadingSystem threading;

	public struct Enemy {
		public EnemyComponent data;
		public int id;
		public Transform transform;
		public Rigidbody rigidbody;
		public Vector3 position;
		public Vector3 velocity;

		public Enemy (EnemyComponent enemy, int id, Transform transform, Rigidbody rigidbody, Vector3 position, Vector3 velocity) {
			this.data = enemy;
			this.id = id;
			this.transform = transform;
			this.rigidbody = rigidbody;
			this.position = position;
			this.velocity = velocity;
		}
	}

	public struct Attractor {
		public Transform transform;
		public Vector3 position;
	}

	void Start(){
		center = transform.position;
		threading = ThreadingSystem.Instance;

		StartCoroutine("LateStart");
	}

	IEnumerator LateStart(){
		yield return new WaitForEndOfFrame();
		updateList = true;
	}

	void Update () {
		if (updateList) {
			updateList = false;

			CollectData ();
			CollectAttractors();
		}

		UpdateEnemies();
	}

	public bool useThreading;

	void UpdateEnemies(){
		for (int i = 0; i < enemies.Length; i++)
		{
			UpdateData(ref enemies[i]);
		}

		UpdateAttractors();		

		if(useThreading){
			threading.AddToThreadQueue(0, () => { GetEnemies(0, enemies.Length / 3); } );
			threading.AddToThreadQueue(1, () => { GetEnemies(enemies.Length / 3, enemies.Length / 3 * 2); } );
			threading.AddToThreadQueue(2, () => { GetEnemies(enemies.Length / 3 * 2, enemies.Length); } );
		} else {
			GetEnemies(0, enemies.Length);
		}
		
	}

	void UpdateData(ref Enemy enemy) {
		enemy.position = enemy.transform.position;
		enemy.velocity = enemy.rigidbody.velocity;
	}

	void GetEnemies(int start, int end){
		for (int i = start; i < end; i++)
		{
			GetWalkDirection (enemies[i]);
		}
	}

	void CollectData () {
		EnemyComponent[] enemies = GameObject.FindObjectsOfType<EnemyComponent> ();
		this.enemies = new Enemy[enemies.Length];

		for (int i = 0; i < enemies.Length; i++) {
			enemies[i].transform.name = "Enemy nr." + i;
			this.enemies[i] = new Enemy (enemies[i], i, enemies[i].transform, enemies[i].GetComponent<Rigidbody> (), enemies[i].transform.position, Vector3.zero);
		}
	}

	void CollectAttractors(){
		ZombieAttractor[] attractors = FindObjectsOfType<ZombieAttractor>();
		this.attractors = new Attractor[attractors.Length];

		for (int i = 0; i < attractors.Length; i++)
		{
			this.attractors[i] = new Attractor();
			this.attractors[i].transform = attractors[i].transform;
			this.attractors[i].position = this.attractors[i].transform.position;
		}
	}

	void UpdateAttractors(){
		for (int i = 0; i < attractors.Length; i++)
		{
			attractors[i].position = attractors[i].transform.position;
		}
	}

	public Vector3 GetFuturePosition (Enemy enemy) {
		return enemy.position + enemy.velocity;
	}

	Vector3 GetNearbyAttractor(Vector3 position, float distance){
		float neighborDistanceSqrt = distance * distance;

		for (int i = 0; i < attractors.Length; i++){
			if(Vector3.SqrMagnitude(position - attractors[i].position) < neighborDistanceSqrt){
				return attractors[i].position;
			}
		}

		return Vector3.zero;
	}

	void GetWalkDirection (Enemy enemy) {
		Vector3 force = Vector3.zero;

		Vector3 attractor = GetNearbyAttractor(enemy.position, enemy.data.neighborDistance);

		if(attractor != Vector3.zero)
		{
			force = attractor - enemy.position;
		} 
		else
		{
			int[] neighborIDs = GetNeighbors (enemy.id, enemy.position, enemy.data.neighborDistance);

			if (enemy.data.flock) {
				force += Flock (enemy, neighborIDs);
			}

			if (enemy.data.wander) {
				force += Wander (enemy);
			}

			if (enemy.data.align) {
				force += Align (enemy, neighborIDs);
			}

			if (enemy.data.avoid) {
				force += Avoid (enemy, neighborIDs);
			}
		}

		force += KeepWithinArea(enemy);

		UnityAction DoStuff = () => {
			Seek(enemy, force + enemy.position);
			RotateGameObject(enemy);
		};

		DoStuff.Invoke();

		// threading.Schedule(DoStuff);
	}

	Vector3 Wander (Enemy enemy) {
		Vector3 force = Vector3.zero;

		if (enemy.velocity == Vector3.zero) {
			force += RandomVector ();
		} else {
			float angleOffset = 45;
			Vector3 offset = Quaternion.Euler (0, RandomFloat * angleOffset, 0) * enemy.velocity;

			force = enemy.velocity + offset;
		}

		return force;
	}

	Vector3 Avoid (Enemy enemy, int[] neighborIDs) {
		Vector3 force = Vector3.zero;
		
		int[] intrusiveNeighbors = GetNeighbors (enemy.id, enemy.position, enemy.data.personalSpace, neighborIDs);

		float personalSpaceSqr = enemy.data.personalSpace * enemy.data.personalSpace;

		for (int i = 0; i < intrusiveNeighbors.Length; i++) {
			int neighborID = intrusiveNeighbors[i];

			Vector3 angleTowardsNeighbor = enemies[neighborID].position - enemy.position;

			if (Vector3.SqrMagnitude (angleTowardsNeighbor) < personalSpaceSqr) {
				force -= angleTowardsNeighbor;
			}
		}

		return force;
	}

	Vector3 KeepWithinArea (Enemy enemy) {
		Vector3 force = Vector3.zero;
		Bounds bounds = new Bounds(center, area);

		if(!bounds.Contains(enemy.position)) {
			force = bounds.ClosestPoint(enemy.position) - enemy.position;
		}

		return force;
	}

	Vector3 Align (Enemy enemy, int[] neighbors) {
		if (neighbors.Length < 3) {
			return Vector3.zero;
		}

		Vector3 force = Vector3.zero;

		Vector3[] directions = new Vector3[neighbors.Length];

		for (int i = 0; i < neighbors.Length; i++) {
			directions[i] = enemies[neighbors[i]].velocity;
		}

		Vector3 averageDirection = GetAverageVector (enemy, directions);

		if (averageDirection != Vector3.zero) {
			force = averageDirection;
		}

		return force;
	}

	Vector3 Flock (Enemy enemy, int[] neighborIDs) {
		Vector3[] neighborPositions = new Vector3[neighborIDs.Length];

		for (int i = 0; i < neighborIDs.Length; i++)
		{
			neighborPositions[i] = enemies[neighborIDs[i]].position;
		}

		Vector3 averagePosition = GetAverageVector (enemy, neighborPositions);

		Vector3 towardsAverage = averagePosition - enemy.position;
		Vector3 force = Vector3.zero;

		if (towardsAverage.magnitude > enemy.data.personalSpace) 
		{
			force = towardsAverage;
		}

		return force;
	}

	void Seek (Enemy enemy, Vector3 target) {
		// The desired direction
		Vector3 desired;
		// Amount of force to apply
		Vector3 steer;

		desired = target - GetFuturePosition (enemy);
		desired = desired.normalized;
		desired *= enemy.data.maxSpeed;

		// Find the force to apply 
		steer = desired - enemy.velocity;
		steer = steer.normalized * enemy.data.maxForce;

		// Add force to physics system
		enemy.rigidbody.AddForce (steer);
	}

	void RotateGameObject (Enemy enemy) {
		enemy.transform.LookAt (enemy.velocity + enemy.position);
	}

	int[] GetNeighbors (int id, Vector3 position, float radius) {
		int[] neighborIDs = new int[enemies.Length];

		for (int i = 0; i < enemies.Length; i++) {
			neighborIDs[i] = i;
		}

		return GetNeighbors(id, position, radius, neighborIDs);
	}

	int[] GetNeighbors (int id, Vector3 position, float radius, int[] enemyIDs) {
		List<int> neighbors = new List<int> ();

		float radiusSqr = radius * radius;

		for (int i = 0; i < enemyIDs.Length; i++) {
			if(enemyIDs[i] == id){
				continue;
			}

			float sqrMagnitude = Vector3.SqrMagnitude (enemies[enemyIDs[i]].position - position);

			if (sqrMagnitude < radiusSqr) {
				neighbors.Add (i);
			}
		}

		return neighbors.ToArray ();
	}

	Vector3 GetAverageVector (Enemy enemy, Vector3[] positions) {
		Vector3 sum = Vector3.zero;

		// Get the sum of all the positions
		for (int i = 0; i < positions.Length; i++) {
			sum += positions[i];
		}
		return sum / positions.Length;
	}

	float RandomFloat { get { return (float)random.Next(-100, 100) / 100f; } }

	// Get a random vector 3
	Vector3 RandomVector () {
		return new Vector3(RandomFloat, 0, RandomFloat);
	}

	void OnDrawGizmosSelected () {
		// Display area restriction
		Gizmos.DrawWireCube (center, area);
	}
}

public interface IAIBehavior {
	Vector3 GetForce(EnemyComponent enemy);
}