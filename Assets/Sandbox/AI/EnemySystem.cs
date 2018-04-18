using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemySystem : MonoBehaviour {

	public bool updateList = true;
	public Vector3 area;

	Enemy[] enemies;

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

	void Update () {
		if (updateList) {
			updateList = false;

			CollectData ();
		}

		UpdateData(enemies[0]);	
		Thread testThread = new Thread (TestTest);
		testThread.Start();

		for (int i = 1; i < enemies.Length; i++) {
			UpdateData(enemies[i]);
			Seek(enemies[i], GetWalkDirection (enemies[i]) + enemies[i].position);
		}
	}

	void UpdateData(Enemy enemy) {
		enemy.position = enemy.transform.position;
		enemy.velocity = enemy.rigidbody.velocity;
	}

	void TestTest () {
		GetWalkDirection (enemies[0]);
	}

	void CollectData () {
		EnemyComponent[] enemies = GameObject.FindObjectsOfType<EnemyComponent> ();
		this.enemies = new Enemy[enemies.Length];

		for (int i = 0; i < enemies.Length; i++) {
			this.enemies[i] = new Enemy (enemies[i], enemies[i].transform, enemies[i].GetComponent<Rigidbody> (), enemies[i].transform.position, Vector3.zero);
		}
	}

	public Vector3 GetFuturePosition (Enemy enemy) {
		Vector3 futurePosition = enemy.position + enemy.velocity;
		return futurePosition;
	}

	Vector3 GetWalkDirection (Enemy enemy) {
		Vector3 force = Vector3.zero;
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

		return force;
		// force += KeepWithinArea (enemy);

		// Seek (enemy, force + enemy.position);

		// RotateGameObject (enemy);
	}

	Vector3 Wander (Enemy enemy) {
		Vector3 force = Vector3.zero;

		Vector3 direction = Vector3.zero;
		float angleOffset = 45;
		Vector3 offset = Quaternion.Euler (0, angleOffset, 0) * enemy.velocity;

		if (enemy.velocity == Vector3.zero) {
			force += RandomVector ();
		}

		direction += enemy.velocity + offset;

		return direction;
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
		if (enemy.position.x < transform.position.x + -area.x / 2) {
			force += Vector3.right;
		}
		// Outside East side
		else if (enemy.position.x > transform.position.x + area.x / 2) {
			force += Vector3.left;
		}
		// Outside South side
		if (enemy.position.z < transform.position.z + -area.z / 2) {
			force += Vector3.forward;
		}
		// Outside North side
		else if (enemy.position.z > transform.position.z + area.z / 2) {
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
			directions[i] = enemies[neighbors[i]].rigidbody.velocity;
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

		float radiusSqrt = Mathf.Sqrt (radius);

		for (int i = 0; i < array.Length; i++) {
			float sqrtMagnitude = Vector3.SqrMagnitude (enemies[i].position - position);

			if (sqrtMagnitude < radiusSqrt) {
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

	Vector3 RandomVector () {
		// return new Vector3 (Random.Range (-1f, 1f), 0, Random.Range (-1f, 1f));
		return new Vector3(1, 1);
	}

	void OnDrawGizmos () {
		Gizmos.DrawWireCube (transform.position, area);
	}
}