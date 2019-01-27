using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public struct CameraTargetComponent : IComponentData { }

public class CameraTargetComponentWrapper : ComponentDataWrapper<CameraTargetComponent> {}
