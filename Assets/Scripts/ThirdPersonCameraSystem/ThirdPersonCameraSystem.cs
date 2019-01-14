using Unity.Entities;
using Unity.Transforms;
using UnityEngine;
using Unity.Collections;

// [UpdateAfter (typeof(TransformSyncSystem))]
// [UpdateAfter (typeof(WaitForFixedUpdate))]
public class ThirdPersonCameraSystem : ComponentSystem {

	struct Data {
		public readonly int Length;
		public ComponentDataArray<ThirdPersonCameraComponent> Camera;
		public ComponentArray<Transform> transform;
		[ReadOnly] public ComponentDataArray<PlayerInputComponent> Input;
	}

	// Should only be one
	struct TargetData {
		public readonly int Length;
		public ComponentDataArray<CameraTargetComponent> Targets;
		// public ComponentArray<Transform> transforms; 
		public ComponentDataArray<Position> positions;
	}

	[Inject] Data data;
	[Inject] TargetData Targets;

    protected override void OnUpdate(){
		for (int i = 0; i < data.Length; i++) {
			// Lock and hide curson
			Cursor.visible = false;
			Cursor.lockState = CursorLockMode.Locked;

			ThirdPersonCameraComponent Camera = data.Camera[i];

			// // Add player as target if no other target is assigned
			// if(Camera.lookPosition == Vector3.zero) 
			// 	Camera.lookPosition = playerData.transforms[0].position;

			Camera.lookPosition = Targets.positions[i].Value;

			Vector3 LookTarget = data.Camera[i].lookPosition;
			LookTarget += data.transform[i].TransformDirection(data.Camera[i].Offset) + data.transform[i].forward;

			Camera.lookDirection += new Vector3(0, data.Input[i].Look.x, 0);
			data.transform[i].rotation = Quaternion.Euler(data.Camera[i].lookDirection);

			ThirdPersonCameraComponent CamComp = data.Camera[i];
			Vector3 CurrentVelocity = data.Camera[i].CurrentVelocity;
			Vector3 TargetPosition = Vector3.SmoothDamp(data.transform[i].position, LookTarget - data.transform[i].forward * data.Camera[i].DistanceToTarget, ref CurrentVelocity, Time.deltaTime);
			CamComp.CurrentVelocity = CurrentVelocity;
			data.Camera[i] = CamComp;

			data.transform[i].position = TargetPosition;
			// data.transform[i].position = LookTarget - data.transform[i].forward * data.Camera[i].DistanceToTarget;

			data.Camera[i] = Camera;
		}
    }
}
