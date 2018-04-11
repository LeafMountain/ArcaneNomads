using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerComponent : MonoBehaviour {

	public GameObject prefab;
	public int amount;
	public float spawnInterval;

	[Header("Read Only")]
	public int numberSpawned;
	public float timeSinceLastSpawn;
}
