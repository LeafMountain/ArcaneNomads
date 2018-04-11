using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody))]
public class EnemyComponent : MonoBehaviour {

	Rigidbody rigidbody;	
	

	// The maximum speed
	public float maxSpeed;
	// How good is it at turning
	public float maxForce;

	public float stoppingDistance = 10;

	public Transform desiredPosition;

	public Vector3 velocity {
		get {
			return rigidbody.velocity;
		}
	}

	public Vector3 futurePosition {
		get {
			return Vector3.ClampMagnitude(transform.position + velocity, maxSpeed);
		}
	}

	void Awake(){
		rigidbody = GetComponent<Rigidbody>();
		desiredPosition = GameObject.Find("Goal").transform;
	}

	void Update(){
		Seek(desiredPosition.position);
	}

	void Seek(Vector3 target){
		// The desired direction
		Vector3 desired;
		// Amount of force to apply
		Vector3 steer;

		desired = target - futurePosition;

		float distanceToTarget = desired.magnitude;
		
		// Slow down when getting within stopping distance
		if(distanceToTarget < stoppingDistance){
			float m = Mathf.Lerp(0, maxSpeed, distanceToTarget / stoppingDistance);
			desired = desired.normalized;
			desired *= m;
		} 
		// Use max speed to get to the desired position
		else {
			desired = desired.normalized;
			desired *= maxSpeed;
		}

		// Find the force to apply 
		steer = desired - velocity;
		steer = Vector3.ClampMagnitude(steer, maxForce);

		// Add force to physics system
		rigidbody.AddForce(steer);

		// Some debug stuff
		Debug.DrawRay(transform.position, steer, Color.yellow);
		Debug.DrawLine(transform.position, futurePosition, Color.white);
	}

	RaycastHit See(){
		Ray vision = new Ray(transform.position, velocity);
		RaycastHit hit;

		Physics.Raycast(vision, out hit, maxSpeed);

		return hit;
	}
}
