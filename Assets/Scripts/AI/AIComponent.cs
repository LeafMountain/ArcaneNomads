﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent (typeof (Rigidbody))]
public class AIComponent : MonoBehaviour
{

	[HideInInspector]
	public Vector3 velocity;
	[HideInInspector]
	public Vector3 position;

	public AITemplate template;

	Rigidbody rigidbody;
	Transform transform;

	void Start ()
	{
		rigidbody = GetComponent<Rigidbody> ();
		transform = GetComponent<Transform> ();
	}

	void Update ()
	{
		position = transform.position;
	}

	void FixedUpdate ()
	{
		velocity = rigidbody.velocity;
		transform.LookAt (transform.position + new Vector3 (velocity.x, 0, velocity.z));
		DoBehaviors ();
	}

	void DoBehaviors ()
	{
		Vector3 force = Vector3.zero;

		for (int i = 0; i < template.behaviors.Length; i++)
		{
			if (template.behaviors[i])
			{
				force += template.behaviors[i].DoBehavior (this);
			}
		}

		Seek (force + position);
	}

	void Seek (Vector3 target)
	{
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
		steer.y = 0;

		// Add force to physics system
		rigidbody.AddForce (steer);
	}

	public Vector3 GetFuturePosition ()
	{
		return position + velocity;
	}

}