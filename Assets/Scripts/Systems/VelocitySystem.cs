using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

public class VelocitySystem : ComponentSystem
{
	public struct Data
	{
		public Rigidbody Rigidbody;
		public Velocity Velocity;
	}

    protected override void OnUpdate()
    {
		foreach (var entitiy in GetEntities<Data>())
		{
			entitiy.Velocity.value = entitiy.Rigidbody.position - entitiy.Velocity.lastPosition;
			entitiy.Velocity.lastPosition = entitiy.Rigidbody.position;
			// Vector3 smoothVelocity = Vector3.SmoothDamp(entitiy.Velocity.value, entitiy.Rigidbody.velocity, ref entitiy.Velocity.velocity, entitiy.Velocity.smoothing);
			// entitiy.Velocity.value = smoothVelocity;
		}
    }
}
