using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

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
		float moveSpeed = 150f;

        foreach (var entity in GetEntities<Data>())
		{
			float3 moveDirection = new float3(entity.Input.Move.x, 0, entity.Input.Move.y);
			entity.Rigidbody.AddRelativeForce(moveDirection * Time.deltaTime * moveSpeed, ForceMode.VelocityChange);

			entity.Rigidbody.rotation = Quaternion.Euler(entity.Rigidbody.rotation.eulerAngles + entity.Transform.up * entity.Input.Look.x);
		}
    }
}
