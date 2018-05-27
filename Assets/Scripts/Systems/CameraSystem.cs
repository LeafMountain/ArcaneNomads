using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

[UpdateAfter (typeof (PlayerInputSystem))]
public class CameraSystem : ComponentSystem
{

	public struct Data
	{
		public CameraComponent Camera;
		public PlayerInput Input;
		public Transform Transform;
	}

	protected override void OnUpdate ()
	{
		foreach (var entity in GetEntities<Data> ())
		{
			Rotate (entity);
			Move (entity);
			Look (entity);
		}
	}

	void Move (Data entity)
	{
		Vector3 lookTarget = entity.Camera.target.position;
		Vector3 offset = entity.Camera.offset;

		offset.x = (entity.Input.swapShoulder) ? -offset.x : offset.x;
		offset.y = (entity.Input.aim) ? 1.5f : 1.2f;
		offset.z = (entity.Input.aim) ? -1 : -3;

		RaycastHit? hitTarget = ViewBlocked (lookTarget + entity.Transform.TransformDirection (offset), entity.Camera.target.position + Vector3.up * offset.y, math.abs (offset.z), entity.Camera.avoid);

		if (hitTarget?.transform != null)
		{
			offset.z = (float) - hitTarget?.distance;
		}

		lookTarget += entity.Transform.TransformDirection (offset);

		entity.Transform.position = Vector3.SmoothDamp (entity.Transform.position, lookTarget, ref entity.Camera.currentVelocity, entity.Camera.smoothing);

		entity.Camera.offset = offset;
	}

	void Rotate (Data entity)
	{
		float pitch = entity.Camera.pitch;
		float yaw = entity.Camera.yaw;

		pitch -= entity.Input.Look.y;
		pitch = math.clamp (pitch, entity.Camera.pitchMinMax.x, entity.Camera.pitchMinMax.y);
		yaw += entity.Input.Look.x % 360;

		entity.Transform.rotation = Quaternion.Euler (pitch, yaw, 0);

		entity.Camera.pitch = pitch;
		entity.Camera.yaw = yaw;
	}

	void Look (Data entity)
	{
		Ray lookRay = new Ray (entity.Transform.position, entity.Transform.forward);
		RaycastHit hit;

		if (Physics.Raycast (lookRay, out hit, Mathf.Infinity))
		{
			entity.Camera.lookPosition = hit.point;
		}
		else
		{
			entity.Camera.lookPosition = lookRay.direction * 10000;
		}
	}

	RaycastHit? ViewBlocked (Vector3 camera, Vector3 target, float distance, LayerMask mask)
	{
		Ray ray = new Ray (target, camera - target);
		RaycastHit hit;

		Physics.Raycast (ray, out hit, distance, mask);

		return hit;
	}
}