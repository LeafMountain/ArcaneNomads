using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
using Unity.Transforms;
using Unity.Mathematics;
using Unity.Collections;

public class MoveSystem : ComponentSystem {

	public struct Data {
		public readonly int Length;
		[ReadOnly] public ComponentDataArray<HeadingComponent> Headings;
		[ReadOnly] public ComponentDataArray<MoveSpeedComponent> Speeds;
		public ComponentArray<CharacterController> Controllers;
		public ComponentDataArray<Position> Positions;
		// public ComponentDataArray<VelocityComponent> Velocity;
	}

	[Inject] Data MoveData;

    protected override void OnUpdate() {
       	for (int i = 0; i < MoveData.Length; i++) {
			Vector3 Position = MoveData.Positions[i].Value;
			float Speed = MoveData.Speeds[i].value;
			float3 Heading = MoveData.Headings[i].value;
			Vector3 HorizontalVelocity = Heading * Speed;
			Vector3 TargetPosition = HorizontalVelocity + Position;

			// VelocityComponent EntityVelocityComponent = MoveData.Velocity[i];
			// Vector3 CurrentVelocity = EntityVelocityComponent.Value;
			// Vector3 SmoothMove = Vector3.SmoothDamp(Position, TargetPosition, ref CurrentVelocity, .3f);
			// EntityVelocityComponent.Value = CurrentVelocity;
			// MoveData.Velocity[i] = EntityVelocityComponent;

			MoveData.Controllers[i].Move(HorizontalVelocity);
			MoveData.Controllers[i].Move(Vector3.down);
			
			// Rotate
			if(HorizontalVelocity != Vector3.zero)
				MoveData.Controllers[i].transform.forward = HorizontalVelocity;
		}
    }
}
