using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public struct InteractFocusComponent : IComponentData { }

// [DisallowMultipleComponent]
public class InteractFocusComponentWrapper : ComponentDataWrapper<InteractFocusComponent> {}
