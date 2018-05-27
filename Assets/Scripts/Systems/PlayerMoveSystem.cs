using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

public class PlayerMoveSystem : ComponentSystem
{

	public struct Data
	{
		public PlayerInput Input;
		public Rigidbody Rigidbody;
		public Transform Transform;
	}

	protected override void OnUpdate ()
	{
		float moveSpeed = 4f;
		Camera camera = Camera.main;

		foreach (var entity in GetEntities<Data> ())
		{
			moveSpeed = (entity.Input.sprint) ? moveSpeed * 2 : moveSpeed;

			Vector3 moveDirection = camera.transform.TransformVector (new Vector3 (entity.Input.Move.x, 0, entity.Input.Move.y));
			moveDirection = moveDirection.normalized;
			moveDirection.y = 0;

			if (moveDirection == Vector3.zero && !entity.Input.aim)
			{
				continue;
			}

			entity.Rigidbody.velocity = moveDirection * moveSpeed;
			Vector3 lookDirection = camera.transform.forward;

			if (!entity.Input.aim)
			{
				lookDirection.y = 0;
			}
			else
			{
				lookDirection = camera.GetComponent<CameraComponent> ().lookPosition - entity.Transform.position;
			}

			entity.Rigidbody.MoveRotation(Quaternion.Lerp (entity.Rigidbody.rotation, Quaternion.LookRotation (lookDirection, Vector3.up), Time.deltaTime * 5));
		}
	}
}