using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

[System.Serializable]
public struct Velocity : IComponentData
{
    public float3 Value;
}

public class VelocityComponent : ComponentDataProxy<Velocity> {}