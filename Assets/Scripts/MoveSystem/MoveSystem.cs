using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class MoveSystem : ComponentSystem {

	public struct Data
	{
		public HeadingComponent heading;
		public MoveSpeedComponent speed;
		public Rigidbody rigidbody;		// Try to exclude this
	}

    protected override void OnUpdate()
    {
       	foreach (var entity in GetEntities<Data>())
		{
			if(entity.heading.value != Vector3.zero) {
				entity.rigidbody.AddForce(entity.heading.value * entity.speed.value, ForceMode.Impulse);
				entity.rigidbody.MoveRotation(Quaternion.LookRotation(entity.heading.value));
			}
		}
    }
}
