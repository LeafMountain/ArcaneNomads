using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

[System.Serializable]
public struct ThirdPersonCameraComponent : IComponentData {
	public Vector3 lookPosition;
	public Vector3 lookDirection;
	public Vector3 Offset;
	public float DistanceToTarget;
	public Vector3 Rotation;
}

public class ThirdPersonCameraComponentWrapper : ComponentDataWrapper<ThirdPersonCameraComponent> {}
