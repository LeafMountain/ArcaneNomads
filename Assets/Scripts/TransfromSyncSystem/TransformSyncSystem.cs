using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
using Unity.Transforms;

public class TransformSyncSystem : ComponentSystem
{
	struct Data {
		public readonly int Length;
		public ComponentDataArray<Position> positions;
		public ComponentArray<Transform> transforms;
	}

	[Inject] Data data;
	
    protected override void OnUpdate(){
		for (int i = 0; i < data.Length; i++){
			Position positionComponent = data.positions[i];
			positionComponent.Value = data.transforms[i].position;			
		}
    }
}
