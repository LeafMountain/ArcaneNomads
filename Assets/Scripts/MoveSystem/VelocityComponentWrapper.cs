using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

[System.Serializable]
public struct VelocityComponent : IComponentData
{
    public float3 Value;
}


public class VelocityComponentWrapper : ComponentDataWrapper<VelocityComponent> {}
