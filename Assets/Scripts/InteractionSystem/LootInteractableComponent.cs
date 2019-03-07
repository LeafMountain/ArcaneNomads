using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

[System.Serializable]
public struct LootInteractable : IComponentData
{
    // public ScriptableObject Loot;
}

public class LootInteractableComponent : ComponentDataProxy<LootInteractable> {}
