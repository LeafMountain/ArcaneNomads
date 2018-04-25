using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/Sensors/Radar")]
public class AIRadar : AISensor {

	public float range;

	Collider[] colliders = new Collider[10];
	
	public override Collider[] GetObjects(AIComponent boid){
		int numberOfColliders = Physics.OverlapSphereNonAlloc(boid.position, range, colliders);

		// Reset the rest of the slots
		for (int i = numberOfColliders; i < colliders.Length; i++)
		{
			colliders[i] = null;
		}

		return colliders;
	}
}
