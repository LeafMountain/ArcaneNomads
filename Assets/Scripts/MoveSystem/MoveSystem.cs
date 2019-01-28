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
		[ReadOnly] public ComponentDataArray<HeadingComponent> Headings;
		[ReadOnly] public ComponentDataArray<MoveSpeedComponent> Speeds;
		[ReadOnly] public ComponentArray<Rigidbody> Rigidbodies;
	}

	[Inject] Data MoveData;

    protected override void OnUpdate() 
	{
       	for (int i = 0; i < MoveData.Length; i++) 
		{
			float Speed = MoveData.Speeds[i].speed;
			float3 Heading = MoveData.Headings[i].value;
			Vector3 HorizontalVelocity = Heading * Speed;
			// HorizontalVelocity = Vector3.ClampMagnitude(HorizontalVelocity, MoveData.Speeds[i].maxSpeed);
			float3 CurrentVelocity = MoveData.Rigidbodies[i].velocity;

			// if(math.length(CurrentVelocity) < MoveData.Speeds[i].maxSpeed)
			// MoveData.Rigidbodies[i].AddForce(HorizontalVelocity, ForceMode.VelocityChange);
			if((Vector3)Heading != Vector3.zero)
				MoveData.Rigidbodies[i].velocity = HorizontalVelocity;
			
			// Rotate
			if(HorizontalVelocity != Vector3.zero)
			{
				Transform transform = MoveData.Rigidbodies[i].transform;
				transform.forward = Vector3.Lerp(transform.forward, Heading, Time.deltaTime * 20);
			}
		}
    }
}
