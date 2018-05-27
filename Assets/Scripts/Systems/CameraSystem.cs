using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

[UpdateAfter(typeof(PlayerInputSystem))]
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
			// Rotation
			float pitch = entity.Camera.pitch;
			float yaw = entity.Camera.yaw;

			pitch -= entity.Input.Look.y;
			pitch = math.clamp(pitch, entity.Camera.pitchMinMax.x, entity.Camera.pitchMinMax.y);
			yaw += entity.Input.Look.x % 360;

			entity.Transform.rotation = Quaternion.Euler(pitch, yaw, 0);

			// Position
			Vector3 lookTarget = entity.Camera.target.position;
			Vector3 offset = entity.Camera.offset;

			offset.x = (entity.Input.swapShoulder) ? -offset.x : offset.x;
			offset.y = (entity.Input.aim) ? 1.5f : 1.2f;			
			offset.z = (entity.Input.aim) ? -1 : -3;
		
			lookTarget += entity.Transform.TransformDirection(offset);

			entity.Transform.position = Vector3.SmoothDamp(entity.Transform.position, lookTarget, ref entity.Camera.currentVelocity, entity.Camera.smoothing);

			Ray lookRay = new Ray(entity.Transform.position, entity.Transform.forward);
			RaycastHit hit;
			Physics.Raycast(lookRay, out hit, Mathf.Infinity);

			// Update variables in components
			entity.Camera.pitch = pitch;
			entity.Camera.yaw = yaw;
			entity.Camera.offset = offset;
			entity.Camera.lookPosition = hit.point;
		}
	}
}
