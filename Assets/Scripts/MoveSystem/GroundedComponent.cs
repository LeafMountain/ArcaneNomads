using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

[System.Serializable]
public struct Grounded : IComponentData
{
    public int Value;
    public float Distance;
}

public class GroundedComponent : ComponentDataProxy<Grounded> {}
