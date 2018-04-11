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
						Instantiate(components[i].prefab, components[i].transform.position, Quaternion.identity, components[i].transform);
					}
					components[i].numberSpawned = components[i].amount;
					components[i].timeSinceLastSpawn = 0;
				}
				else if(components[i].timeSinceLastSpawn > components[i].spawnInterval){
					Instantiate(components[i].prefab, components[i].transform.position, Quaternion.identity, components[i].transform);

					components[i].numberSpawned++;
					components[i].timeSinceLastSpawn = 0;
				}
			}
		}
	}
}
