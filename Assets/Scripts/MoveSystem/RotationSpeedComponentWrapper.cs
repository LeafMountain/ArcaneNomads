using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public struct RotationSpeedComponent : IComponentData
{
    public float Value;
}

public class RotationSpeedComponentWrapper : ComponentDataProxy<RotationSpeedComponent> {}
