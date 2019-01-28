using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public struct Grounded : IComponentData
{
    public int value;
}

public class GroundedComponent : ComponentDataWrapper<Grounded> {}
