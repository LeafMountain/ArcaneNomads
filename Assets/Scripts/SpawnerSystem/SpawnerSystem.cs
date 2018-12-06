using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class SpawnerSystem : ComponentSystem
{
	struct Data {
		public readonly int Length;
		public EntityArray entities;
		public ComponentDataArray<SpawnerComponent> spawner;
		public ComponentArray<Transform> transform;	// Switch to position component
	}

	[Inject] Data data;

    protected override void OnUpdate(){
		for (int i = 0; i < data.Length; i++) {
			if(data.spawner[i].prefab) {
				// Add object to spawned list
				GameObject prefab = data.spawner[i].prefab;
				Vector3 spawnPosition = data.transform[i].position;
				Quaternion spawnRotation = Quaternion.identity;

				GameObject.Instantiate(prefab, spawnPosition, spawnRotation);
				PostUpdateCommands.RemoveComponent(data.entities[i], typeof(SpawnerComponent));
				// for (int j = 0; j < Mathf.Min(data.spawner[i].NumberToSpawn, data.spawner[i].SpawnedObjects.Length); j++) {
				// 	if(!data.spawner[i].SpawnedObjects[j]) {
				// 		data.spawner[i].SpawnedObjects[j] = NewObject;
				// 	}
				// }
			}
		}
	}
}
