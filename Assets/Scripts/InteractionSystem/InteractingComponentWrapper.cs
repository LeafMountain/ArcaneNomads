using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public struct InteractingComponent : IComponentData {}

public class InteractingComponentWrapper : ComponentDataWrapper<InteractingComponent> {}