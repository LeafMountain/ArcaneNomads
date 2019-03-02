using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

[System.Serializable]
public struct Equipper : IComponentData
{

}

public class EquipperComponent : ComponentDataWrapper<Equipper> {}