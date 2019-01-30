using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

[System.Serializable]
public struct Interactor : IComponentData
{
    public float Reach;
    public float Angle;
}

public class InteractorComponent : ComponentDataWrapper<Interactor> {}
