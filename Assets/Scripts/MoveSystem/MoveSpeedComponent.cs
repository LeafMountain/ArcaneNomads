using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

[System.Serializable]
public struct MoveSpeed : IComponentData {
	public float Value;
}

[DisallowMultipleComponent]
public class MoveSpeedComponent : ComponentDataProxy <MoveSpeed> {}

// public class MoveSpeedComponent : ComponentDataProxy<MoveSpeed> {}
