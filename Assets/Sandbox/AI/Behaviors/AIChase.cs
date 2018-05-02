using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/Behaviors/Chase")]
public class AIChase : AIBeahvior {

	public AISensor sensor;

	public override Vector3 DoBehavior(AIComponent boid) {
		Vector3 force = Vector3.zero;
		SuperCharacterController[] player = sensor.GetObjects<SuperCharacterController>(boid);

		if(player != null && player.Length > 0){
			force = player[0].transform.position - boid.position;
		}

		return force;
	}
	
}
