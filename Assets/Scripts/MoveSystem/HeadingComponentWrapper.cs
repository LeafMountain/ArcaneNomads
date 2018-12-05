using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public struct HeadingComponent : IComponentData {
	public Vector3 value;
}

public class HeadingComponentWrapper : ComponentDataWrapper<HeadingComponent> {}

