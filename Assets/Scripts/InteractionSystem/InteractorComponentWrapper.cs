using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

[System.Serializable]
public struct InteractorComponent : IComponentData {
	public float distance;
}

public class InteractorComponentWrapper : ComponentDataWrapper<InteractorComponent> { } 
