using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

[System.Serializable]
public struct Heading : IComponentData {
	public Vector3 Value;
}

public class HeadingComponent : ComponentDataWrapper<Heading> {}

