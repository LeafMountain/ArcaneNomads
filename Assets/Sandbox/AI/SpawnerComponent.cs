using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerComponent : MonoBehaviour {

	public GameObject prefab;
	public int amount;
	public float spawnInterval;
	public Vector2 spawnArea;

	[Header("Read Only")]
	public int numberSpawned;
	public float timeSinceLastSpawn;

	GameObject[] spawnedObjects;

	void Start(){
		spawnedObjects = new GameObject[amount];

		for (int i = 0; i < amount; i++)
		{
			spawnedObjects[i] = Spawn(this);
		}
	}

	GameObject Spawn(SpawnerComponent component){
		Vector2 spawnArea = component.spawnArea;

		Vector3 spawnPosition = RandomPosition(spawnArea);

		Collider[] colliders = Physics.OverlapSphere(spawnPosition, 0);

		for (int i = 0; i < colliders.Length; i++)
		{
			spawnPosition = colliders[i].bounds.ClosestPoint(spawnPosition);
		}
		
		GameObject go = Instantiate(component.prefab, component.transform.position + spawnPosition, Quaternion.Euler(new Vector3(0, Random.Range(0, 359), 0)), component.transform);
		component.numberSpawned++;
		component.timeSinceLastSpawn = 0;

		return go;
	}

	Vector3 RandomPosition(Vector2 area){
		float spawnX = Random.Range(-(area.x / 2), area.x / 2);
		float spawnY = Random.Range(-(area.y / 2), area.y / 2);		

		return new Vector3(spawnX, 20, spawnY);
	}

	void OnDrawGizmosSelected(){
		Gizmos.color = Color.red;
		Gizmos.DrawWireCube(transform.position, new Vector3(spawnArea.x, 0, spawnArea.y));
	}
}
