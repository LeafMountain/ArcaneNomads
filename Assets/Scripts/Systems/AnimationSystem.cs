using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class AnimationSystem : ComponentSystem
{

	public struct Data
	{
		public Rigidbody rigidbody;
		public Animator animator;
		// public SuperCharacterController characterController;
	}

    protected override void OnUpdate()
    {
        foreach (var entity in GetEntities<Data>())
		{
			Vector3 velocity = entity.rigidbody.velocity;
			entity.animator.SetFloat("velocityX", velocity.x);
			entity.animator.SetFloat("velocityY", velocity.z);
		}
    }
}
