using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

[UpdateAfter (typeof (PlayerInputSystem))]
public class ThirdPersonCameraSystem : ComponentSystem {

	struct Data{
		public ThirdPersonCameraComponent Component;
		public Transform transform;
		public PlayerInputComponent Input;
	}

    protected override void OnUpdate(){
		foreach(var Entity in GetEntities<Data>()) {
			// Add player as target if no other target is assigned
			if(!Entity.Component.Target) {
				Entity.Component.Target = GameObject.FindObjectOfType<Player>()?.transform;
			}

			Vector3 LookTarget = Entity.Component.Target.position;
			LookTarget += Entity.transform.TransformDirection(Entity.Component.Offset) + Entity.Component.transform.forward;

			Entity.Component.YRotation += Entity.Input.Look.x;
			Entity.transform.RotateAround(LookTarget, Vector3.up, Entity.Input.Look.x);
			Entity.transform.LookAt(Entity.Component.Target);
			Entity.transform.position = LookTarget - Entity.transform.forward * Entity.Component.DistanceToTarget;
			
		}
    }
}
