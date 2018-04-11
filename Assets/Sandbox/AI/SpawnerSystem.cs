using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSystem : ComponentSystem<SpawnerComponent> {

	protected override void OnUpdate(){
		for (int i = 0; i < components.Length; i++)
		{			
			if(components[i].numberSpawned < components[i].amount)
			{
				components[i].timeSinceLastSpawn += Time.deltaTime;

				if(components[i].spawnInterval == 0){
					for (int y = 0; y < components[i].amount; y++)
					{
						Spawn(components[i]);
					}
				}
				else if(components[i].timeSinceLastSpawn > components[i].spawnInterval){
					Spawn(components[i]);
				}
			}
		}
	}

	void Spawn(SpawnerComponent component){
		Vector2 spawnArea = component.spawnArea;

		float spawnX = Random.Range(-(spawnArea.x / 2), spawnArea.x / 2);
		float spawnY = Random.Range(-(spawnArea.y / 2), spawnArea.y / 2);

		Vector3 spawnPosition = new Vector3(spawnX, 0, spawnY);
		
		Instantiate(component.prefab, component.transform.position + spawnPosition, Quaternion.Euler(new Vector3(0, Random.Range(0, 359), 0)), component.transform);
		component.numberSpawned++;
		component.timeSinceLastSpawn = 0;
	}
}
