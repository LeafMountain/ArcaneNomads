using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using System;

[Serializable]
public struct HealthComponent : IComponentData
{
    public int Value;
}

[DisallowMultipleComponent]
public class HealthComponentWrapper : ComponentDataWrapper<HealthComponent> {}