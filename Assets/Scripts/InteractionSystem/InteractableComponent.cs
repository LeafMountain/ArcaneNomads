using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

[System.Serializable]
public struct Interactable : IComponentData
{
}

public class InteractableComponent : ComponentDataWrapper<Interactable> {}
