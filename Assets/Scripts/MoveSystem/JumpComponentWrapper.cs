using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

[System.Serializable]
public struct JumpComponent : IComponentData
{
    public float Force;
}

public class JumpComponentWrapper: ComponentDataProxy<JumpComponent> {}
