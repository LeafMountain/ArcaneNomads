using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using System;

[Serializable]
public struct ECSHealthComponent : IComponentData
{
    public int Value;
}

public class HealthComponent : ComponentDataWrapper<ECSHealthComponent> {}