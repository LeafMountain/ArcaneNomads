using UnityEngine;

[CreateAssetMenu(menuName ="AI/Behaviors/Align")]
public class Align : AIBeahvior {

	public int neighborMinLimit = 2;

	public override Vector3 DoBehavior (AISystem system, Boid boid) {
		Boid[] neighbors = system.GetNeighbors(boid.id, boid.position, boid.data.neighborDistance);

		if (neighbors.Length < neighborMinLimit) {
			return Vector3.zero;
		}

		Vector3 force = Vector3.zero;

		Vector3[] directions = new Vector3[neighbors.Length];

		for (int i = 0; i < neighbors.Length; i++) {
			directions[i] = system.boids[i].velocity;
		}

		Vector3 averageDirection = system.GetAverageVector (boid, directions);

		if (averageDirection != Vector3.zero) {
			force = averageDirection;
		}

		return force;
	}
}