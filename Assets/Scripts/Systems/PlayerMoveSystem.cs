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
		public Rigidbody rigidbody;
	}

    protected override void OnUpdate()
    {
		float moveSpeed = .1f;

        foreach (var entity in GetEntities<Data>())
		{
			if(entity.Input.Move != Vector2.zero)
			{
				entity.rigidbody.MovePosition (entity.rigidbody.position + new Vector3(entity.Input.Move.x, 0, entity.Input.Move.y) * moveSpeed);
			}
		}
    }
}
