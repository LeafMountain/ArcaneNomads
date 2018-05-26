using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatePlayer : MonoBehaviour {

	Animator animator;
	SuperCharacterController characterController;
	Rigidbody rigidbody;

	public Vector3 velocity;

	void Start () {
		animator = GetComponentInChildren<Animator>();
		// characterController = GetComponent<SuperCharacterController>();
		rigidbody = GetComponent<Rigidbody>();
	}
	
	void Update () {
		animator.SetFloat("velocityX", velocity.x);
		animator.SetFloat("velocityY", velocity.z);
	}

	void FixedUpdate ()
	{
		velocity = rigidbody.velocity;
	}
}
