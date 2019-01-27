using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

// Destroy gameobjects with the destroy tag component
public class DestroySystem : ComponentSystem
{
	struct DestroyData {
		public readonly int Length;
		[ReadOnly] public ComponentDataArray<DestroyComponent> components;
		public ComponentArray<Transform> transforms;
	}

	[Inject] DestroyData destroyData;

    protected override void OnUpdate(){
		for (int i = 0; i < destroyData.Length; i++) {
			GameObject.Destroy(destroyData.transforms[i].gameObject);
		}
    }
}
