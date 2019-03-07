using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

[System.Serializable]
public struct Interactable : IComponentData
{

}

public class InteractableComponent : ComponentDataProxy<Interactable> {}
