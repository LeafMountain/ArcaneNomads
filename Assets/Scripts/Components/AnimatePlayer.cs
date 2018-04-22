using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatePlayer : MonoBehaviour {

	Animator animator;
	SuperCharacterController characterController;

	void Start () {
		animator = GetComponentInChildren<Animator>();
		characterController = GetComponent<SuperCharacterController>();
	}
	
	void Update () {
		Vector3 velocity = characterController.Velocity.normalized;
		animator.SetFloat("velocityX", velocity.x);
		animator.SetFloat("velocityY", velocity.z);
	}
}
