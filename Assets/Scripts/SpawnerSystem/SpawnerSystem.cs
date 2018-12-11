using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class SpawnerSystem : ComponentSystem
{
	struct Data {
		public readonly int Length;
		public EntityArray entities;
		public ComponentArray<SpawnerComponentWrapper> spawners;
		public ComponentArray<Transform> transform;	// Switch to position component
	}

	[Inject] Data data;

    protected override void OnUpdate() {
		for (int i = 0; i < data.Length; i++) {
			if(data.spawners[i].objectToSpawn != null && data.spawners[i].spawnedEntities == 0) {
				// Store relevant information for clarity
				GameObject prefab = data.spawners[i].objectToSpawn;
				Vector3 spawnPosition = data.transform[i].position;
				Quaternion spawnRotation = Quaternion.identity;

				// Spawn the prefab
				GameObject.Instantiate(prefab, spawnPosition, spawnRotation);

				// Remove the spawner component to stop the infinite loop of spawning
				// SpawnerComponentWrapper component = data.transform[i].gameObject.GetComponent<SpawnerComponentWrapper>();
				// GameObject.Destroy(data.transform[i].gameObject.GetComponent<SpawnerComponentWrapper>());

				// PostUpdateCommands.RemoveComponent(data.entities[i], typeof(SpawnerComponentWrapper));

				data.spawners[i].spawnedEntities++;
			}
		}
	}
}
