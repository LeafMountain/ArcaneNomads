using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public struct Destroy : IComponentData { }

public class DestroyComponent : ComponentDataProxy<Destroy> { }