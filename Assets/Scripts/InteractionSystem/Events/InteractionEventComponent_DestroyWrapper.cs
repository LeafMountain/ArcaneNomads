using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public struct InteractionEventComponent_Destroy : IComponentData { }

public class InteractionEventComponent_DestroyWrapper : ComponentDataWrapper<InteractionEventComponent_Destroy> { }
