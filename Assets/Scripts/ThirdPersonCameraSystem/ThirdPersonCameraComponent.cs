using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraComponent : MonoBehaviour {
	public Transform Target;
	public Vector3 lookDirection = Vector3.forward;
	public Vector3 Offset;
	public float DistanceToTarget = 10;
	public float YRotation;
}
