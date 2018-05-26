using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraComponent : MonoBehaviour {

	public Transform target;
	public Vector3 offset;

	[Range (0, 1)] public float smoothing;

	public float pitch;

	public Vector2 minMaxPitch;

	public LayerMask avoid;

	[HideInInspector] public Vector3 currentVelocity;
}
