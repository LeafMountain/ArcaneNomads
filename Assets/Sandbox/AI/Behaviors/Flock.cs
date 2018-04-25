
using UnityEngine;

[CreateAssetMenu(menuName ="AI/Behaviors/Flock")]
public class Flock : AIBeahvior {
	public override Vector3 DoBehavior (AISystem system, Boid boid) {
		Boid[] neighbors = system.GetNeighbors(boid.id, boid.position, boid.data.neighborDistance);

		Vector3[] neighborPositions = new Vector3[neighbors.Length];

		for (int i = 0; i < neighbors.Length; i++)
		{
			neighborPositions[i] = neighbors[i].position;
		}

		Vector3 averagePosition = system.GetAverageVector (boid, neighborPositions);

		Vector3 towardsAverage = averagePosition - boid.position;

		Vector3 force = Vector3.zero;

		if (towardsAverage.magnitude > boid.data.personalSpace)
		{
			force = towardsAverage;
		}

		return force;
	}
}