using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class SpawnerSystem : ComponentSystem
{
	struct Data{
		public SpawnerComponent Spawner;
	}

    protected override void OnUpdate(){
		foreach(var Entity in GetEntities<Data>()){
			if(Entity.Spawner.ObjectToSpawn) {
				// Add object to spawned list
				for (int i = 0; i < Mathf.Min(Entity.Spawner.NumberToSpawn, Entity.Spawner.SpawnedObjects.Length); i++) {
					if(!Entity.Spawner.SpawnedObjects[i]){
						GameObject NewObject = GameObject.Instantiate(Entity.Spawner.ObjectToSpawn);
						Entity.Spawner.SpawnedObjects[i] = NewObject;
					}
				}
			}
		}
	}

}
