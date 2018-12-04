using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerComponent : MonoBehaviour {

	public GameObject ObjectToSpawn;
	
	public int NumberToSpawn = 1;
	public const int MAXIMUMALLOWEDOBJECTS = 100;

	[HideInInspector]
	public GameObject[] SpawnedObjects = new GameObject[MAXIMUMALLOWEDOBJECTS];
}

