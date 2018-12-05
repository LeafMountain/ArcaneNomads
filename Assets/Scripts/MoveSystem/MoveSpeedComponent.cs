using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public struct MoveSpeedComponent : IComponentData {
	public float value;
}

[DisallowMultipleComponent]
public class MoveSpeedComponentWrapper : ComponentDataWrapper <MoveSpeedComponent> {}
