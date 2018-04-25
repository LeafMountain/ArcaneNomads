using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AIComponent : MonoBehaviour {

	public int id;
	
	// The maximum speed
	public float maxSpeed;
	// How good is it at turning
	public float maxForce;
	public float personalSpace;
	public float neighborDistance;

	// public AIBeahvior[] behaviors;

	// void FixedUpdate(){

	// }

	// void DoBehaviors(){
	// 	for (int i = 0; i < behaviors.Length; i++)
	// 	{
	// 		behaviors[i].DoBehavior(this);
	// 	}
	// }

	void OnDrawGizmosSelected(){
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(transform.position, neighborDistance);

		Color personalColor = new Color(1, 0, 0, 1);
		Gizmos.color = personalColor;
		Gizmos.DrawWireSphere(transform.position, personalSpace);
	}
}
