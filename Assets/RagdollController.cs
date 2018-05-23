using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollController : MonoBehaviour {

	Rigidbody[] rbs;
	Collider[] colliders;

	void Start () {
		rbs = GetComponentsInChildren<Rigidbody> ();
		colliders = GetComponentsInChildren<Collider> ();

		TurnOff ();
	}

	public void TurnOff () {
		foreach (var rb in rbs) {
			rb.isKinematic = true;
		}

		foreach (var col in colliders) {
			col.enabled = false;
		}
	}

	public void TurnOn () {
		foreach (var rb in rbs) {
			rb.isKinematic = false;
		}

		foreach (var col in colliders) {
			col.enabled = true;
		}
	}
}