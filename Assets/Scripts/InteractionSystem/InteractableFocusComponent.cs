using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public struct InteractableFocus : IComponentData
{
    
}

public class InteractableFocusComponent : ComponentDataWrapper<InteractableFocus> {}
