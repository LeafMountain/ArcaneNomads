using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
using Unity.Transforms;
using Unity.Mathematics;
using Unity.Collections;

[UpdateBefore(typeof(UnityEngine.Experimental.PlayerLoop.FixedUpdate))]
public class MoveSystem : ComponentSystem
{
	public struct Data 
	{
		public readonly int Length;
		// [ReadOnly] public ComponentDataArray<Heading> Headings;
		// [ReadOnly] public ComponentDataArray<MoveSpeed> Speeds;
		public ComponentDataArray<Velocity> Velocities;
		[ReadOnly] public ComponentArray<Rigidbody> Rigidbodies;
	}

	[Inject] Data MoveData;

    protected override void OnUpdate() 
	{
       	for (int i = 0; i < MoveData.Length; i++) 
		{
			Velocity VelocityComp = MoveData.Velocities[i];
			float3 Velocity = VelocityComp.Value;
			
			// // Rotate
			if((Vector3)MoveData.Velocities[i].Value != Vector3.zero)
			{
				MoveData.Rigidbodies[i].velocity = Velocity;
				Transform transform = MoveData.Rigidbodies[i].transform;
				transform.forward = Vector3.Lerp(transform.forward, Velocity, Time.deltaTime * 20);
			}

			// VelocityComp.Value = MoveData.Rigidbodies[i].velocity;
			MoveData.Velocities[i] = VelocityComp;
		}
    }
}
