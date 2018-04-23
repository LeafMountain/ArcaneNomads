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
		public Transform transform;
		public Rigidbody rigidbody;
		public Vector3 position;
		public Vector3 velocity;

		public Enemy (EnemyComponent enemy, Transform transform, Rigidbody rigidbody, Vector3 position, Vector3 velocity) {
			this.data = enemy;
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

	IEnumerable LateStart(){
		yield return new WaitForSeconds(5f);
		updateList = true;
		Debug.Log("LateStart");
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

		if(useThreading){
			threading.AddToThreadQueue(0, () => { GetEnemies(0, enemies.Length / 4); } );
			threading.AddToThreadQueue(1, () => { GetEnemies(enemies.Length / 4, enemies.Length / 2); } );
			threading.AddToThreadQueue(2, () => { GetEnemies(enemies.Length / 2, enemies.Length / 4 * 3); } );
			threading.AddToThreadQueue(3, () => { GetEnemies(enemies.Length / 4 * 3, enemies.Length); } );
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
			this.enemies[i] = new Enemy (enemies[i], enemies[i].transform, enemies[i].GetComponent<Rigidbody> (), enemies[i].transform.position, Vector3.zero);
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

	void GetWalkDirection (Enemy enemy) {
		Vector3 force = Vector3.zero;

		UpdateAttractors();
		float neighborDistanceSqrt = enemy.data.neighborDistance * enemy.data.neighborDistance;
		bool attractorNearby = false;
		Attractor attractor = new Attractor();

		for (int i = 0; i < attractors.Length; i++)
		{
			if(Vector3.SqrMagnitude(enemy.position - attractors[i].position) < neighborDistanceSqrt){
				attractorNearby = true;
				attractor = attractors[i];
				break;
			}
		}

		if(attractorNearby){
			force = attractor.position - enemy.position;
		} else {
			int[] neighbors = GetEnemiesWithinRadius (enemy.position, enemy.data.neighborDistance);

			if (enemy.data.flock) {
				force += Flock (enemy, neighbors);
			}

			if (enemy.data.wander) {
				force += Wander (enemy);
			}

			if (enemy.data.align) {
				force += Align (enemy, neighbors);
			}

			if (enemy.data.avoid) {
				force += Avoid (enemy, neighbors);
			}
		}

		force += KeepWithinArea(enemy);

		UnityAction DoStuff = () => {
			Seek(enemy, force + enemy.position);
			RotateGameObject(enemy);
		};

		threading.Schedule(DoStuff);
	}

	Vector3 Wander (Enemy enemy) {
		Vector3 force = Vector3.zero;

		if (enemy.velocity == Vector3.zero) {
			force += RandomVector ();
		} else {
			float angleOffset = 45;
			Vector3 offset = Quaternion.Euler (0, RandomInt * angleOffset, 0) * enemy.velocity;

			force = enemy.velocity + offset;
		}

		return force;
	}

	Vector3 Avoid (Enemy enemy, int[] neighbors) {
		Vector3 force = Vector3.zero;
		int[] neigh = GetEnemiesWithinRadius (enemy.position, enemy.data.personalSpace);

		float personalSpaceSqrt = Mathf.Sqrt (enemy.data.personalSpace);

		for (int i = 0; i < neigh.Length; i++) {
			int enemyIndex = neigh[i];

			if (enemies[enemyIndex].data == enemy.data) {
				continue;
			}

			Vector3 angleTowardsNeighbor = enemies[enemyIndex].position - enemy.position;

			if (Vector3.SqrMagnitude (angleTowardsNeighbor) < personalSpaceSqrt) {
				force -= angleTowardsNeighbor;
			}
		}

		return force;
	}

	Vector3 KeepWithinArea (Enemy enemy) {
		Vector3 force = Vector3.zero;

		// Outside West side
		if (enemy.position.x < center.x + -area.x / 2) {
			force += Vector3.right;
		}
		// Outside East side
		else if (enemy.position.x > center.x + area.x / 2) {
			force += Vector3.left;
		}
		// Outside South side
		if (enemy.position.z < center.z + -area.z / 2) {
			force += Vector3.forward;
		}
		// Outside North side
		else if (enemy.position.z > center.z + area.z / 2) {
			force += Vector3.back;
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

	Vector3 Flock (Enemy enemy, int[] neighbors) {
		Vector3 averagePosition = GetAveragePosition (enemy, neighbors);
		float distanceToTarget = (averagePosition - enemy.position).magnitude;
		Vector3 force = Vector3.zero;

		if (distanceToTarget > enemy.data.personalSpace) {
			force = averagePosition;
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

	int[] GetEnemiesWithinRadius (Vector3 position, float radius) {
		return GetEnemiesWithinRadius (position, radius, enemies);
	}

	int[] GetEnemiesWithinRadius (Vector3 position, float radius, Enemy[] array) {
		List<int> neighbors = new List<int> ();

		float radiusSqr = radius * radius;

		for (int i = 0; i < array.Length; i++) {
			float sqrtMagnitude = Vector3.SqrMagnitude (enemies[i].position - position);

			if (sqrtMagnitude < radiusSqr) {
				neighbors.Add (i);
			}
		}

		return neighbors.ToArray ();
	}

	Vector3 GetAveragePosition (Enemy enemy, int[] positions) {
		Vector3 sum = Vector3.zero;

		// Get the sum of all the positions
		for (int i = 0; i < positions.Length; i++) {
			sum += enemies[positions[i]].position;
		}

		return sum / positions.Length;
	}

	Vector3 GetAverageVector (Enemy enemy, Vector3[] positions) {
		Vector3 sum = Vector3.zero;

		// Get the sum of all the positions
		for (int i = 0; i < positions.Length; i++) {
			sum += positions[i];
		}
		return sum / positions.Length;
	}

	float RandomInt {
		get {
			return (float)random.Next(-100, 100) / 100f;
		}
	}

	Vector3 RandomVector () {
		return new Vector3(RandomInt, 0, RandomInt);
	}

	void OnDrawGizmosSelected () {
		Gizmos.DrawWireCube (center, area);
	}
}