using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/Behaviors/Avoid")]
public class AIAvoid : AIBeahvior {

	public AISensor sensor;

	public override Vector3 DoBehavior (AIComponent boid) {
		AIComponent[] neighbors = GetNeighbors(boid);

		Vector3[] neighborPositions = new Vector3[neighbors.Length];

		for (int i = 0; i < neighbors.Length; i++)
		{
			neighborPositions[i] = neighbors[i].position;
		}

		Vector3 averagePosition = GetAverageVector (boid, neighborPositions);

		Vector3 force = boid.position - averagePosition;

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
