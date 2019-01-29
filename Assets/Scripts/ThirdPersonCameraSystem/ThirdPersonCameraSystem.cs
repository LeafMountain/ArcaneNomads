using Unity.Entities;
using Unity.Transforms;
using UnityEngine;
using Unity.Collections;
using Unity.Mathematics;

[UpdateAfter(typeof(MoveSystem))]
[UpdateBefore(typeof(UnityEngine.Experimental.PlayerLoop.FixedUpdate))]
public class ThirdPersonCameraSystem : ComponentSystem {

	struct Data {
		public readonly int Length;
		public ComponentDataArray<ThirdPersonCamera> Camera;
		public ComponentArray<Transform> transform;
		[ReadOnly] public ComponentDataArray<PlayerInputComponent> Input;
	}

	// Should only be one
	struct TargetData {
		public readonly int Length;
		public ComponentDataArray<CameraTarget> Targets;
		public ComponentDataArray<Position> positions;
	}

	[Inject] Data Cameras;
	[Inject] TargetData Targets;

    protected override void OnUpdate(){
		for (int i = 0; i < Cameras.Length; i++) {
			// Lock and hide curson (Maybe shouldnt be in the camera system)
			Cursor.visible = false;
			Cursor.lockState = CursorLockMode.Locked;

			ThirdPersonCamera Camera = Cameras.Camera[i];
			Vector3 CameraPosition = Cameras.transform[i].position;
			Vector3 TargetPosition = Targets.positions[i].Value;
			TargetPosition += Cameras.transform[i].TransformDirection(Cameras.Camera[i].Offset) + Cameras.transform[i].forward;

			Camera.LookPosition = Targets.positions[i].Value;

			float DistanceToTarget = GetDesiredDistance(CameraPosition, TargetPosition, Cameras.Camera[i].DistanceToTarget, Cameras.Camera[i].Obstacles);

			Camera.LookDirection += new Vector3(-Cameras.Input[i].Look.y, Cameras.Input[i].Look.x, 0);
			Cameras.transform[i].rotation = Quaternion.Euler(Cameras.Camera[i].LookDirection);

			// ThirdPersonCamera CamComp = Cameras.Camera[i];
			Vector3 CurrentVelocity = Cameras.Camera[i].CurrentVelocity;
			Vector3 DesiredPosition = Vector3.SmoothDamp(Cameras.transform[i].position, TargetPosition - Cameras.transform[i].forward * DistanceToTarget, ref CurrentVelocity, Cameras.Camera[i].Smoothing);
			Camera.CurrentVelocity = CurrentVelocity;
			Cameras.Camera[i] = Camera;

			Cameras.transform[i].position = DesiredPosition;

			Cameras.Camera[i] = Camera;
		}
    }

	float GetDesiredDistance(float3 CameraPosition, float3 TargetPosition, float MaxDistance, LayerMask Mask)
	{
		float DesiredDistance = MaxDistance;
		float3 RayDirection = CameraPosition - TargetPosition;

		Ray ObstacleRay = new Ray(TargetPosition, RayDirection);
		RaycastHit Hit;

		if(Physics.Raycast(ObstacleRay, out Hit, math.length(RayDirection), Mask))
			DesiredDistance = Hit.distance;

		// Debug.DrawRay(TargetPosition, math.normalize(RayDirection) * DesiredDistance, Color.red, 0.1f);

		return DesiredDistance;
	}
}
