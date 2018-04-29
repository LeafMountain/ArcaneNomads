﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent (typeof (Rigidbody))]
public class AIComponent : MonoBehaviour {

	[HideInInspector]
	public Vector3 velocity;
	public Vector3 position;

	public AITemplate template;

	Rigidbody rigidbody;
	Transform transform;

	void Start () {
		rigidbody = GetComponent<Rigidbody> ();
		transform = GetComponent<Transform> ();
	}

	void Update () {
		position = transform.position;
		RotateTowardsVelocity ();
	}

	void FixedUpdate () {
		velocity = rigidbody.velocity;
		DoBehaviors ();
	}

	void DoBehaviors () {
		Vector3 force = Vector3.zero;

		for (int i = 0; i < template.behaviors.Length; i++) {
			if (template.behaviors[i]) {
				force += template.behaviors[i].DoBehavior (this);
			}
		}

		Seek (force + position);
	}

	void Seek (Vector3 target) {
		// The desired direction
		Vector3 desired;
		// Amount of force to apply
		Vector3 steer;

		desired = target - GetFuturePosition ();
		desired = desired.normalized;
		desired *= template.maxSpeed;

		// Find the force to apply 
		steer = desired - velocity;
		steer = steer.normalized * template.maxForce;

		// Add force to physics system
		rigidbody.AddForce (steer);
	}

	public Vector3 GetFuturePosition () {
		return position + velocity;
	}

	void RotateTowardsVelocity () {
		if (velocity != Vector3.zero) {
			Quaternion lookRot = Quaternion.LookRotation (velocity);
			transform.rotation = lookRot;
		}
	}

	void OnDrawGizmosSelected () {
		Gizmos.DrawRay (position, velocity * 2);
	}
}