using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class SpawnerSystem : ComponentSystem
{
	struct Data{
		public SpawnerComponent spawner;
		public Transform transform;
	}

    protected override void OnUpdate(){
		foreach(var entity in GetEntities<Data>()){
			if(entity.spawner.ObjectToSpawn) {
				// Add object to spawned list
				for (int i = 0; i < Mathf.Min(entity.spawner.NumberToSpawn, entity.spawner.SpawnedObjects.Length); i++) {
					if(!entity.spawner.SpawnedObjects[i]){
						GameObject NewObject = GameObject.Instantiate(entity.spawner.ObjectToSpawn, entity.transform.position, Quaternion.identity);
						entity.spawner.SpawnedObjects[i] = NewObject;
					}
				}
			}
		}
	}

}
