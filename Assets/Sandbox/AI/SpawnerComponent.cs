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

	void OnDrawGizmos(){
		Gizmos.DrawWireCube(transform.position, new Vector3(spawnArea.x, 0, spawnArea.y));
	}
}
