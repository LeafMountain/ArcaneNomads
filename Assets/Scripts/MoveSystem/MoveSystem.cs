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
			
			// Rotate
			if((Vector3)MoveData.Velocities[i].Value != Vector3.zero)
			{
				float3 CurrentVelocity = MoveData.Rigidbodies[i].velocity;
				Velocity = new float3(Velocity.x == 0 ? CurrentVelocity.x : Velocity.x, Velocity.y == 0 ? CurrentVelocity.y : Velocity.y, Velocity.z == 0 ? CurrentVelocity.z : Velocity.z);
				MoveData.Rigidbodies[i].velocity = Velocity;
			}

			MoveData.Velocities[i] = VelocityComp;
		}
    }
}
