using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCamera : MonoBehaviour {

	public Transform target;

	public float distanceToTarget;

	[Range (0, 1)]
	public float smoothing;

	public Vector3 rotation;
	Vector3 desiredRotation;
	Vector3 desiredPosition;

	public LayerMask mask;

	Vector3 currentVelocity;

	void Start () {
		desiredRotation = rotation.normalized;
	}

	void LateUpdate () {
		desiredRotation = desiredRotation.normalized;

		if (ViewBlocked ()) {
			desiredPosition = target.position + new Vector3 (-.1f, 1, -.1f) * distanceToTarget;
		} else {
			desiredPosition = (target.position + (desiredRotation) * distanceToTarget);
		}

		transform.position = Vector3.SmoothDamp (transform.position, desiredPosition, ref currentVelocity, smoothing);

		transform.LookAt (target);
	}

	bool ViewBlocked () {
		Vector3 origin = target.GetComponent<Collider> ().bounds.center;
		Vector3 direction = desiredRotation * distanceToTarget;
		direction.Normalize ();

		Ray ray = new Ray (origin, direction);

		Debug.DrawRay (origin, direction * distanceToTarget, Color.red);

		return Physics.Raycast (ray, distanceToTarget, mask);
	}
}