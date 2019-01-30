using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
using Unity.Transforms;

[UpdateAfter (typeof(WaitForFixedUpdate))]
public class TransformSyncSystem : ComponentSystem
{
	struct EntityData {
		public readonly int Length;
		public ComponentDataArray<Position> positions;
		// public ComponentDataArray<Rotation> Rotations;
		public ComponentArray<Transform> Transforms;
	}

	[Inject] EntityData Data;
	
    protected override void OnUpdate(){
		for (int i = 0; i < Data.Length; i++){
			// if(Data.Transforms[i].position != Vector3.zero)
			// {
			// Data.Transforms[i].position = Data.positions[i].Value;
			// }
			// else
			// {
				Position PositionComponent = Data.positions[i];
				PositionComponent.Value = Data.Transforms[i].position;
				Data.positions[i] = PositionComponent;

				
			// }
		}
    }
}
