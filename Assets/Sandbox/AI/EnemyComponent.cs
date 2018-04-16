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
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(transform.position, neighborDistance);

		Color personalColor = new Color(1, 0, 0, .6f);
		Gizmos.color = personalColor;
		Gizmos.DrawSphere(transform.position, personalSpace);
	}
}
