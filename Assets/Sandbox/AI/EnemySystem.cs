using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class EnemySystem : MonoBehaviour  {

	public bool updateList = true; 
	public Vector3 area; 

	public EnemyComponent[] enemies;
	public Transform[] enemyPositions;

	// struct Data {
	// 	public EnemyComponent[] enemies;
	// 	public Transform[] enemyPositions;
	// }


	void Update() {
		if (updateList) {
			updateList = false; 

			CollectData();
		}
		
		for (int i = 0; i < enemies.Length; i ++) {
			DoBehaviour(enemies[i]);
		}
	}

	void CollectData(){
		enemies = GameObject.FindObjectsOfType<EnemyComponent>();
		enemyPositions = new Transform[enemies.Length];

		for (int i = 0; i < enemies.Length; i++)
		{
			Setup(enemies[i]);
			enemyPositions[i] = enemies[i].transform;
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
	}

	void DoBehaviour(EnemyComponent enemy) {
		Vector3 force = Vector3.zero;
		int[] neighbors = GetEnemiesWithinRadius(enemy.transform.position, enemy.neighborDistance);
		
		if (enemy.flock) {
			force += Flock(enemy, neighbors); 
		}

		if (enemy.wander) {
			force += Wander(enemy); 
		}

		if (enemy.align) {
			force += Align(enemy, neighbors); 
		}

		if(enemy.avoid){
			force += Avoid(enemy, neighbors);
		}

		force += KeepWithinArea(enemy);

		Seek(enemy, force + enemy.transform.position);

		RotateGameObject(enemy);
	}

	Vector3 Wander(EnemyComponent enemy) {
		Vector3 force = Vector3.zero;
		// if (Random.Range(0, 100) < 50) {
		// 	return; 
		// }

		Vector3 direction = Vector3.zero; 
		float angleOffset = 45; 
		Vector3 offset = Quaternion.Euler(0, Random.Range( - angleOffset, angleOffset), 0) * GetVelocity(enemy); 

		if (GetVelocity(enemy) == Vector3.zero) {
			force += RandomVector();
			// enemy.rigidbody.AddForce(new Vector3(Random.Range(-1f, 1), 0, Random.Range(-1f, 1))); 
		}

		direction += GetVelocity(enemy) + offset; 

		return direction;
	}

	Vector3 Avoid(EnemyComponent enemy, int[] neighbors) {
		Vector3 force = Vector3.zero;
		int[] neigh = GetEnemiesWithinRadius(enemy.transform.position, enemy.personalSpace);

		float personalSpaceSqrt = Mathf.Sqrt(enemy.personalSpace);


		for (int i = 0; i < neigh.Length; i++){
			int enemyIndex = neigh[i];

			if(enemies[enemyIndex] == enemy){
				continue;
			}

			Vector3 angleTowardsNeighbor = enemyPositions[enemyIndex].position - enemy.transform.position;

			if(Vector3.SqrMagnitude(angleTowardsNeighbor) < personalSpaceSqrt){
				force -= angleTowardsNeighbor;
			}
		}

		return force;

	}

	Vector3 KeepWithinArea(EnemyComponent enemy) {
		Vector3 force = Vector3.zero;

		// Outside West side
		if (enemy.transform.position.x < transform.position.x +  - area.x / 2) {
			force += Vector3.right; 
		}
		// Outside East side
		else if (enemy.transform.position.x > transform.position.x + area.x / 2) {
			force += Vector3.left; 
		}
		// Outside South side
		if (enemy.transform.position.z < transform.position.z +  - area.z / 2) {
			force += Vector3.forward; 
		}
		// Outside North side
		else if (enemy.transform.position.z > transform.position.z + area.z / 2) {
			force += Vector3.back; 
		}

		return force;
	}


	Vector3 Align(EnemyComponent enemy, int[] neighbors) {
		if (Random.Range(0, 100) < 1 || neighbors.Length < 3) {
			return Vector3.zero; 
		}

		Vector3 force = Vector3.zero;

		Vector3[] directions = new Vector3[neighbors.Length]; 

		for (int i = 0; i < neighbors.Length; i++) {
			directions[i] = GetVelocity(enemies[neighbors[i]]); 
		}

		Vector3 averageDirection = GetAverageVector(enemy, directions); 

		if (averageDirection != Vector3.zero) {
			force = averageDirection;
		}

		return force;
	}

	Vector3 Flock(EnemyComponent enemy, int[] neighbors) {
		Vector3 averagePosition = GetAveragePosition(enemy, neighbors); 
		float distanceToTarget = (averagePosition - enemy.transform.position).magnitude;
		Vector3 force = Vector3.zero;

		if(distanceToTarget > enemy.personalSpace){
			force = averagePosition;
		}

		return force;
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
		enemy.rigidbody.AddForce(steer);
	}

	void RotateGameObject(EnemyComponent enemy) {
		enemy.transform.LookAt(GetVelocity(enemy) + enemy.transform.position);
	}

	int[] GetEnemiesWithinRadius(Vector3 position, float radius) {
		return GetEnemiesWithinRadius(position, radius, enemies); 
	}

	int[] GetEnemiesWithinRadius(Vector3 position, float radius, EnemyComponent[] array) {
		List <int> neighbors = new List <int> (); 

		float radiusSqrt = Mathf.Sqrt(radius);
		
		for (int y = 0; y < array.Length; y++)
		{
			float sqrtMagnitude = Vector3.SqrMagnitude(enemyPositions[y].position - position);
			
			if (sqrtMagnitude < radiusSqrt) 
			{
				neighbors.Add(y);
			}	
		}

		return neighbors.ToArray(); 
	}

	Vector3 GetAveragePosition(EnemyComponent enemy, int[] positions) {
		Vector3 sum = Vector3.zero; 

		// Get the sum of all the positions
		for (int i = 0; i < positions.Length; i++) {
			sum += enemyPositions[positions[i]].position; 
		}

		return sum / positions.Length; 
	}

	Vector3 GetAverageVector(EnemyComponent enemy, Vector3[] positions) {
		Vector3 sum = Vector3.zero; 

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
