using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraComponent : MonoBehaviour {

	public Transform target;
	public Vector3 offset;

	[Range (0, 1)] public float smoothing;

	public float pitch;
	public float yaw;

	public Vector2 pitchMinMax;

	public Vector3 lookPosition;

	// public LayerMask avoid;

	[HideInInspector] public Vector3 currentVelocity;
}
