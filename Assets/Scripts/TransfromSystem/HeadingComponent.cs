using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

[System.Serializable]
public struct Heading : IComponentData {
	public float3 Value;
}

public class HeadingComponent : ComponentDataProxy<Heading> {}

