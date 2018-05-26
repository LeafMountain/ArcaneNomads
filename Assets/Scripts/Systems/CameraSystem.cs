using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

[UpdateAfter(typeof(PlayerInputSystem)), UpdateAfter(typeof(PlayerMoveSystem))]
public class CameraSystem : ComponentSystem {

	public struct Data
	{
		public CameraComponent Camera;
		public PlayerInput Input;
		public Transform Transform;
	}

	protected override void OnUpdate () 
	{
		foreach (var entity in GetEntities<Data>())
		{
			Vector3 targetPosition = entity.Camera.target.position + entity.Camera.target.TransformDirection(new Vector3(entity.Camera.offset.x, entity.Camera.offset.y));
			Vector3 desiredPositon = targetPosition;

			Vector3 lookRotation = entity.Transform.rotation.eulerAngles;
			lookRotation.x -= entity.Input.Look.y;
			lookRotation.x = math.clamp(lookRotation.x, entity.Camera.minMaxPitch.y, entity.Camera.minMaxPitch.x);

			Debug.Log(math.clamp(lookRotation.y, entity.Camera.minMaxPitch.y, 300));

			lookRotation.y = entity.Camera.target.transform.rotation.eulerAngles.y;

			entity.Transform.rotation = Quaternion.Euler(lookRotation);

			desiredPositon -= entity.Camera.target.forward * entity.Camera.offset.z;

			Vector3 smoothPosition = Vector3.SmoothDamp(entity.Transform.position, desiredPositon, ref entity.Camera.currentVelocity, entity.Camera.smoothing);
			entity.Transform.position = smoothPosition;

			
		}
	}
}
