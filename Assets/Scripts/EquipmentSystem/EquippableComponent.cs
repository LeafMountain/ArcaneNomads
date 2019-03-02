using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

[System.Serializable]
public struct Equippable : IComponentData
{
    // reference to equipper?
}

public class EquippableComponent : ComponentDataWrapper<Equippable> {}
