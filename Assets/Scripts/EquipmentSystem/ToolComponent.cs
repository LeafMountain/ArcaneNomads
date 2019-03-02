using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

[System.Serializable]
public struct Tool : IComponentData
{

}

public class ToolComponent : ComponentDataWrapper<Tool> {}
