using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	[HideInInspector] public static Player Instance;

	void Start () {
		if (!Instance) {
			Instance = this;
		} else {
			Destroy (this);
		}
	}

	public void ToggleInput (bool enabled) {
		GetComponent<InputMapper> ().enabled = enabled;
		GetComponent<MouseLook> ().enabled = enabled;
	}
}