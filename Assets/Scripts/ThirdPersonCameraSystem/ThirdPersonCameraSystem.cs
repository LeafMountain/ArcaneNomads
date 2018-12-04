using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

[UpdateAfter (typeof (PlayerInputSystem))]
public class ThirdPersonCameraSystem : ComponentSystem {

	struct Data{
		public ThirdPersonCameraComponent Camera;
		public Transform transform;
		public PlayerInputComponent Input;
	}

    protected override void OnUpdate(){
		foreach(var Entity in GetEntities<Data>()) {
			// Lock and hide curson
			Cursor.visible = false;
			Cursor.lockState = CursorLockMode.Locked;

			// Add player as target if no other target is assigned
			if(!Entity.Camera.Target) {
				Entity.Camera.Target = GameObject.FindObjectOfType<PlayerComponent>()?.transform;
			}

			Vector3 LookTarget = Entity.Camera.Target.position;
			LookTarget += Entity.transform.TransformDirection(Entity.Camera.Offset) + Entity.Camera.transform.forward;

			Entity.Camera.lookDirection += new Vector3(0, Entity.Input.Look.x, 0);
			Entity.transform.rotation = Quaternion.Euler(Entity.Camera.lookDirection);
			Entity.transform.position = LookTarget - Entity.transform.forward * Entity.Camera.DistanceToTarget;
		}
    }
}
