using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

[System.Serializable]
public struct ThirdPersonCamera : IComponentData {
	public Vector3 LookPosition;
	public Vector3 LookDirection;
	public Vector3 Offset;
	public float DistanceToTarget;
	public Vector3 Rotation;
	public Vector3 CurrentVelocity;
	public LayerMask Obstacles;
	[Range(0.001f, 1)]
	public float Smoothing;
}

public class ThirdPersonCameraComponent : ComponentDataWrapper<ThirdPersonCamera> {}
