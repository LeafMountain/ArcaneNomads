using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public struct DestroyComponent : IComponentData { }

public class DestroyComponentWrapper : ComponentDataWrapper<DestroyComponent> { }