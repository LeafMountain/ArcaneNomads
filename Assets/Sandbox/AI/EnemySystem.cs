using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.AI; 

public class EnemySystem:ComponentSystem < EnemyComponent >  {

	public bool updateList = true; 
	public Vector3 area; 

	protected override void OnUpdate() {
		if (updateList) {
			updateList = false; 
			UpdateComponentsList(); 

			for (int i = 0; i < components.Length; i++) {
				if ( ! components[i].rigidbody) {
					Setup(components[i]); 
				}
			}
		}
		
		for (int i = 0; i < components.Length; i++) {
			DoBehaviour(components[i]); 
		}
	}

	public Vector3 GetVelocity(EnemyComponent enemy) {
		return enemy.rigidbody.velocity; 
	}

	public Vector3 GetFuturePosition(EnemyComponent enemy) {
		Vector3 futurePosition = enemy.transform.position + GetVelocity(enemy); 
		// enemy.futurePosition = futurePosition;
		return futurePosition; 
	}

	void Setup(EnemyComponent enemy) {
		enemy.rigidbody = enemy.GetComponent < Rigidbody > (); 
		enemy.rigidbody.AddForce(RandomVector(), ForceMode.VelocityChange); 
		// enemy.neighbors = new Collider[enemy.numberOfNeighbors];
	}

	void DoBehaviour(EnemyComponent enemy) {
		EnemyComponent[] neighbors = GetNeighbors(enemy);
		
		if (enemy.flock) {
			Flock(enemy); 
		}

		if (enemy.wander) {
			Wander(enemy); 
		}

		if (enemy.align) {
			Align(enemy, neighbors); 
		}

		if(enemy.avoid){
			Avoid(enemy, neighbors);
		}

		KeepWithinArea(enemy);
		RotateGameObject(enemy);
	}

	void Wander(EnemyComponent enemy) {
		if (Random.Range(0, 100) < 50) {
			return; 
		}

		Vector3 direction = Vector3.zero; 
		float angleOffset = 15; 
		Vector3 offset = Quaternion.Euler(0, Random.Range( - angleOffset, angleOffset), 0) * GetVelocity(enemy); 

		if (GetVelocity(enemy) == Vector3.zero) {
			enemy.rigidbody.AddForce(new Vector3(Random.Range(-1f, 1), 0, Random.Range(-1f, 1))); 
		}

		direction = enemy.transform.position + GetVelocity(enemy) + offset; 

		Seek(enemy, direction); 
	}

	void Avoid(EnemyComponent enemy, EnemyComponent[] neighbors) {
		if(enemy.personalSpace == 0){
			return;
		}

		for (int i = 0; i < neighbors.Length; i++){
			Vector3 angleTowardsNeighbor = neighbors[i].transform.position - enemy.transform.position;

			if(angleTowardsNeighbor.magnitude < enemy.personalSpace){
				Seek(enemy, transform.position - angleTowardsNeighbor);
			}
		}

	}

	void KeepWithinArea(EnemyComponent enemy) {
		// Outside West side
		if (enemy.transform.position.x < transform.position.x +  - area.x / 2) {
			Seek(enemy, Vector3.right); 
		}
		// Outside East side
		else if (enemy.transform.position.x > transform.position.x + area.x / 2) {
			Seek(enemy, Vector3.left); 
		}
		// Outside South side
		if (enemy.transform.position.z < transform.position.z +  - area.z / 2) {
			Seek(enemy, Vector3.forward); 
		}
		// Outside North side
		else if (enemy.transform.position.z > transform.position.z + area.z / 2) {
			Seek(enemy, Vector3.back); 
		}
	}

	void Align(EnemyComponent enemy, EnemyComponent[] neighbors) {
		if (Random.Range(0, 100) < 1 || neighbors.Length < 3) {
			return; 
		}

		Vector3[] directions = new Vector3[neighbors.Length]; 

		for (int i = 0; i < neighbors.Length; i++) {
			directions[i] = GetVelocity(neighbors[i]); 
		}

		Vector3 averageDirection = GetAveragePosition(enemy, directions); 

		if (averageDirection != Vector3.zero) {
			Seek(enemy, enemy.transform.position + averageDirection); 
		}
	}

	void Flock(EnemyComponent enemy) {
		EnemyComponent[] enemies = GetNeighbors(enemy); 
		// Vector3[] positionsOfNeightbors = ExtractPositions(enemies);
		Vector3 averagePosition = GetAveragePosition(enemy, enemies); 
		float distanceToTarget = (averagePosition - enemy.transform.position).magnitude; 

		Seek(enemy, averagePosition); 
	}

	void Arrive() {		
		// Slow down when getting within stopping distance
		// if(distanceToTarget < stoppingDistance){
		// 	float m = Mathf.Lerp(0, maxSpeed, distanceToTarget / stoppingDistance);
		// 	desired = desired.normalized;
		// 	desired *= m;
		// } 
		// // Use max speed to get to the desired position
		// else {
			// desired = desired.normalized;
			// desired *= enemy.maxSpeed;
		// }
	}

	void Seek(EnemyComponent enemy, Vector3 target) {
		// The desired direction
		Vector3 desired; 
		// Amount of force to apply
		Vector3 steer; 

		desired = target - GetFuturePosition(enemy); 
		desired = desired.normalized; 
		desired *= enemy.maxSpeed; 

		// Find the force to apply 
		steer = desired - GetVelocity(enemy); 
		steer = steer.normalized * enemy.maxForce; 

		// Add force to physics system
		enemy.rigidbody.AddForce(steer, ForceMode.Acceleration);

		// Debug.DrawRay(enemy.transform.position, steer, Color.red);
	}

	void RotateGameObject(EnemyComponent enemy) {
		enemy.transform.LookAt(GetVelocity(enemy)); 
	}

	// RaycastHit See(EnemyComponent enemy){
	// 	Ray vision = new Ray(enemy.transform.position, GetVelocity(enemy));
	// 	RaycastHit hit;

	// 	Physics.Raycast(vision, out hit, enemy.maxSpeed);

	// 	return hit;
	// }

	EnemyComponent[] GetNeighbors(EnemyComponent enemy) {
		List < EnemyComponent > neighbors = new List < EnemyComponent > (); 

		for (int y = 0; y < components.Length; y++) {
			if (Vector3.Distance(components[y].transform.position, enemy.transform.position) < enemy.neighborDistance && components[y] != enemy) {
				neighbors.Add(components[y]); 
			}
		}

		return neighbors.ToArray(); 
	}

	Vector3 GetAveragePosition(EnemyComponent enemy, EnemyComponent[] positions) {
		Vector3 sum = Vector3.zero; 
		enemy.numberOfNeighbors = positions.Length; 

		// Get the sum of all the positions
		for (int i = 0; i < positions.Length; i++) {
			sum += positions[i].transform.position; 
		}

		return sum / positions.Length; 
	}

	Vector3 GetAveragePosition(EnemyComponent enemy, Vector3[] positions) {
		Vector3 sum = Vector3.zero; 
		enemy.numberOfNeighbors = positions.Length; 

		// Get the sum of all the positions
		for (int i = 0; i < positions.Length; i++) {
			sum += positions[i]; 
		}

		return sum / positions.Length; 
	}

	Vector3 RandomVector() {
		return new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)); 
	}

	void OnDrawGizmos() {
		Gizmos.DrawWireCube(transform.position, area); 
	}
}
