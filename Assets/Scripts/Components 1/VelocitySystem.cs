using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class VelocitySystem : ComponentSystem
{
	public struct Data
	{
		public Velocity velocity;
		public Transform transform;
	}

    protected override void OnUpdate()
    {
		foreach (var entitiy in GetEntities<Data>())
		{
			entitiy.velocity.value = entitiy.velocity.lastPosition - entitiy.transform.position;
			entitiy.velocity.lastPosition = entitiy.transform.position;
		}
    }
}
