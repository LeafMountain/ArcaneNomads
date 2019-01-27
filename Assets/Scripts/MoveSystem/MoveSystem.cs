using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
using Unity.Transforms;
using Unity.Mathematics;
using Unity.Collections;

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
			float Speed = MoveData.Speeds[i].value;
			float3 Heading = MoveData.Headings[i].value;
			Vector3 HorizontalVelocity = Heading * Speed;

			MoveData.Rigidbodies[i].AddForce(HorizontalVelocity, ForceMode.VelocityChange);
			
			// Rotate
			if(HorizontalVelocity != Vector3.zero)
			{
				Transform transform = MoveData.Rigidbodies[i].transform;
				transform.forward = Vector3.Lerp(transform.forward, Heading, Time.deltaTime * 20);
			}
		}
    }
}
