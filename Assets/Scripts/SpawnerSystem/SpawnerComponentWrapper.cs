using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

[System.Serializable]
public struct SpawnerComponent : IComponentData {
	public GameObject ObjectToSpawn;
}

public class SpawnerComponentWrapper : ComponentDataWrapper<SpawnerComponent> {}

