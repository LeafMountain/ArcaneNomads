using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Entities;
using UnityEngine;

[UpdateAfter (typeof (PlayerInputSystem))]
public class ThirdPersonCameraSystem : ComponentSystem {

	struct Data{
		public readonly int Length;
		public ThirdPersonCameraComponent Camera;
		public Transform transform;
		public PlayerInputComponent Input;
	}

	struct PlayerData {
		public readonly int Length;
		public ComponentDataArray<PlayerComponent> players;
		public ComponentArray<Transform> transforms; 
	}

	[Inject] Data data;
	[Inject] PlayerData playerData;

    protected override void OnUpdate(){
		for (int i = 0; i < data.Length; i++) {

			// Lock and hide curson
			Cursor.visible = false;
			Cursor.lockState = CursorLockMode.Locked;

			// Add player as target if no other target is assigned
			if(!Entity.Camera.Target) {
				Entity.Camera.Target = playerData.transforms[0];
			}

			Vector3 LookTarget = Entity.Camera.Target.position;
			LookTarget += Entity.transform.TransformDirection(Entity.Camera.Offset) + Entity.Camera.transform.forward;

			Entity.Camera.lookDirection += new Vector3(0, Entity.Input.Look.x, 0);
			Entity.transform.rotation = Quaternion.Euler(Entity.Camera.lookDirection);
			Entity.transform.position = LookTarget - Entity.transform.forward * Entity.Camera.DistanceToTarget;
		}
    }
}
