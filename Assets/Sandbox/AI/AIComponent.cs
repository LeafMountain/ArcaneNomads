using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System.Threading;

[RequireComponent(typeof(Rigidbody))]
public class AIComponent : MonoBehaviour {

	[HideInInspector]
	public Vector3 velocity;
	public Vector3 position;
	

	public AITemplate template;

	Rigidbody rigidbody;
	Transform transform;

	void Start(){
		rigidbody = GetComponent<Rigidbody>();
		transform = GetComponent<Transform>();
	}

	void Update(){
		position = transform.position;
		RotateTowardsVelocity();
	}

	// Thread thread;

	void FixedUpdate(){
		velocity = rigidbody.velocity;
		DoBehaviors();

		// thread = new Thread(DoBehaviors);
		// thread.Start();

		// for (int i = 0; i < actionQueue.Count; i++)
		// {
		// 	UnityAction action = actionQueue.Peek();
		// 	actionQueue.Dequeue();

		// 	action.Invoke();
		// }
	}

	void DoBehaviors(){
		Vector3 force = Vector3.zero;

		for (int i = 0; i < template.behaviors.Length; i++)
		{
			force += template.behaviors[i].DoBehavior(this);
		}

		// actionQueue.Enqueue(() => Seek(force + position));

		Seek(force + position);
	}

	Queue<UnityAction> actionQueue = new Queue<UnityAction>();

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
		if(velocity != Vector3.zero){
			Quaternion lookRot = Quaternion.LookRotation(velocity);
			transform.rotation = lookRot;
		}
	}

	void OnDrawGizmosSelected(){
		Gizmos.DrawRay(position, velocity * 2);
	}
}
