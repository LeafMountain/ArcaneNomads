using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

[UpdateAfter(typeof(CameraSystem))]
public class PlayerMoveSystem : ComponentSystem 
{

	public struct Data
	{
		public PlayerInput Input;
		public Rigidbody Rigidbody;
		public Transform Transform;
	}

    protected override void OnUpdate()
    {
		float moveSpeed = 5f;
		Camera camera = Camera.main;

        foreach (var entity in GetEntities<Data>())
		{
			moveSpeed = (entity.Input.sprint) ? moveSpeed * 2: moveSpeed;

			float3 moveDirection = camera.transform.TransformVector(new float3(entity.Input.Move.x, 0, entity.Input.Move.y));
			moveDirection.y = 0;

			if((Vector3)moveDirection == Vector3.zero)
			{
				continue;
			}

			entity.Rigidbody.velocity = (moveDirection * moveSpeed);
			Vector3 lookDirection = camera.transform.forward;
			lookDirection.y = 0;
			entity.Transform.rotation = Quaternion.LookRotation(lookDirection, Vector3.up);
		}
    }
}
