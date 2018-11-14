using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class MoveSystem : ComponentSystem {

	public struct Data
	{
		public MoveSpeed Speed;
		public Rigidbody Rigidbody;
	}

    protected override void OnUpdate()
    {
       	foreach (var entity in GetEntities<Data>())
		{
			entity.Rigidbody.AddForce(entity.Rigidbody.position * entity.Speed.value);
		}
    }
}
