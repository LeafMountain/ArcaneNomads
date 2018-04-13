using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody))]
public class EnemyComponent : MonoBehaviour {

	Rigidbody rigidbody;
	Collider[] neighbors;	
	
	// The maximum speed
	public float maxSpeed;
	// How good is it at turning
	public float maxForce;
	public float stoppingDistance = 10;
	public float personalSpace;
	public float neighborDistance;
	public int numberOfNeighbors = 10;

	[Header("Behaviour")]
	public bool flock;
	public bool wander;
	public bool align;

	public Transform desiredPosition;

	public Vector3 velocity {
		get {
			return rigidbody.velocity;
		}
	}

	public Vector3 futurePosition {
		get {
			return transform.position + velocity;
		}
	}

	void Awake(){
		rigidbody = GetComponent<Rigidbody>();
		desiredPosition = GameObject.Find("Goal").transform;
		neighbors = new Collider[numberOfNeighbors];
	}

	void Update(){
		if(flock){
			Flock();
		}

		if(wander){
			Wander();
		}

		if(align){
			Align();
		}
	}

	void Wander(){
		Vector3 direction = Vector3.zero;
		Vector3 randomDirection = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f));

		direction = transform.position + velocity + randomDirection;
		
		Seek(direction);
	}

	void Avoid(){

	}

	void Align(){
		EnemyComponent[] enemies = GetEnemies();
		Vector3[] directions = new Vector3[enemies.Length];

		for (int i = 0; i < enemies.Length; i++)
		{
			directions[i] = enemies[i].velocity;
		}

		Vector3 averageDirection = GetAveragePosition(directions);
		Seek(averageDirection);
	}

	void Flock(){
		EnemyComponent[] enemies = GetEnemies();
		Vector3[] positionsOfNeightbors = ExtractPositions(enemies);
		Vector3 averagePosition = GetAveragePosition(positionsOfNeightbors);
		float distanceToTarget = (averagePosition - transform.position).magnitude;

		Seek(averagePosition);
	}

	void Seek(Vector3 target){
		// The desired direction
		Vector3 desired;
		// Amount of force to apply
		Vector3 steer;

		desired = target - futurePosition;

		float distanceToTarget = desired.magnitude;
		
		// Slow down when getting within stopping distance
		// if(distanceToTarget < stoppingDistance){
		// 	float m = Mathf.Lerp(0, maxSpeed, distanceToTarget / stoppingDistance);
		// 	desired = desired.normalized;
		// 	desired *= m;
		// } 
		// // Use max speed to get to the desired position
		// else {
			desired = desired.normalized;
			desired *= maxSpeed;
		// }

		// Find the force to apply 
		steer = desired - velocity;
		steer = Vector3.ClampMagnitude(steer, maxForce);

		// Add force to physics system
		rigidbody.AddForce(steer);

		// Some debug stuff
		Debug.DrawRay(transform.position, steer, Color.yellow);
		Debug.DrawLine(transform.position, futurePosition, Color.white);
	}

	RaycastHit See(){
		Ray vision = new Ray(transform.position, velocity);
		RaycastHit hit;

		Physics.Raycast(vision, out hit, maxSpeed);

		return hit;
	}

	Collider[] UpdateNeighbors(){
		Collider myCollider = GetComponent<Collider>();
		Physics.OverlapSphereNonAlloc(transform.position, neighborDistance, neighbors);

		for (int i = 0; i < neighbors.Length; i++)
		{
			if(neighbors[i] == myCollider){
				neighbors[i] = null;
			}
		}
		return neighbors;
	}

	EnemyComponent[] GetEnemies(){
		List<EnemyComponent> enemies = new List<EnemyComponent>();

		UpdateNeighbors();

		foreach(Collider neighbor in neighbors){
			if(neighbor){
				EnemyComponent enemy = neighbor.GetComponent<EnemyComponent>();
				if(enemy){
					enemies.Add(enemy);
				}
			}
		}

		return enemies.ToArray();
	}

	Vector3 GetAveragePosition(Vector3[] positions){
		Vector3 sum = Vector3.zero;
		numberOfNeighbors = positions.Length;

		// Get the sum of all the positions
		for (int i = 0; i < positions.Length; i++)
		{
			sum += positions[i];
		}

		return sum / positions.Length;
	}

	Vector3 GetGroupPosition(){
		return Vector3.zero;
	}

	Vector3[] ExtractPositions(EnemyComponent[] objects){
		Vector3[] positions = new Vector3[objects.Length];

		for (int i = 0; i < objects.Length; i++)
		{
			positions[i] = objects[i].transform.position;
		}

		return positions;
	}

	void OnDrawGizmosSelected(){
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(transform.position, neighborDistance);

		Color personalColor = new Color(1, 0, 0, .6f);
		Gizmos.color = personalColor;
		Gizmos.DrawSphere(transform.position, personalSpace);
	}
}
