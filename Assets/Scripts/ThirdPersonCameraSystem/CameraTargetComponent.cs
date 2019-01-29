using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public struct CameraTarget : IComponentData { }

public class CameraTargetComponent : ComponentDataWrapper<CameraTarget> {}
