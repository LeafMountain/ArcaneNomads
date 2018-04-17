using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody))]
public class EnemyComponent : MonoBehaviour {

	public Rigidbody rigidbody;
	// public EnemyComponent[] neighbors;
	
	// The maximum speed
	public float maxSpeed;
	// How good is it at turning
	public float maxForce;
	public float stoppingDistance = 10;
	public float personalSpace;
	public float neighborDistance;

	[Header("Behaviour")]
	public bool flock;
	public bool wander;
	public bool align;
	public bool avoid;

	Vector3 futurePosition;

	void OnDrawGizmosSelected(){
		if(flock || align){
			Gizmos.color = Color.green;
			Gizmos.DrawWireSphere(transform.position, neighborDistance);
		}

		if(avoid){
			Color personalColor = new Color(1, 0, 0, 1);
			Gizmos.color = personalColor;
			Gizmos.DrawWireSphere(transform.position, personalSpace);
		}
	}
}
