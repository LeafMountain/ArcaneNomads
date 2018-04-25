
using UnityEngine;

[CreateAssetMenu(menuName ="AI/Behaviors/Flock")]
public class AIFlock : AIBeahvior {

	public AISensor sensor;

	public override Vector3 DoBehavior (AIComponent boid) {
		AIComponent[] neighbors = GetNeighbors(boid);

		Vector3[] neighborPositions = new Vector3[neighbors.Length];

		for (int i = 0; i < neighbors.Length; i++)
		{
			neighborPositions[i] = neighbors[i].position;
		}

		Vector3 averagePosition = GetAverageVector (boid, neighborPositions);

		Vector3 towardsAverage = averagePosition - boid.position;

		Vector3 force = Vector3.zero;

		// if (towardsAverage.magnitude > boid.template.personalSpace)
		// {
		// 	force = towardsAverage;
		// }

		return force;
	}

	AIComponent[] GetNeighbors(AIComponent boid){
		return sensor.GetObjects<AIComponent>(boid);
	}

	Vector3 GetAverageVector (AIComponent enemy, Vector3[] positions) {
		Vector3 sum = Vector3.zero;

		// Get the sum of all the positions
		for (int i = 0; i < positions.Length; i++)
		{
			sum += positions[i];
		}
		return sum / positions.Length;
	}
}