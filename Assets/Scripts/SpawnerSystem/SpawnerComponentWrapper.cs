using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

[System.Serializable]
public class SpawnerComponentWrapper : MonoBehaviour {
	public GameObject objectToSpawn;

	[HideInInspector]
	public int spawnedEntities;
	// [SerializeField]
	// public Prefab prefab;
}

// public class SpawnerComponentWrapper : ComponentDataWrapper<SpawnerComponent> {}

