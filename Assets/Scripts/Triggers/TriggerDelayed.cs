using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerDelayed : MonoBehaviour {

	public float delay;
	public bool startOnEnabled;
	public UnityEvent OnTriggered;

	void OnEnable () {
		if (startOnEnabled) {
			StartTimer ();
		}
	}

	public void Trigger () {
		OnTriggered.Invoke ();
	}

	public void StartTimer () {
		StartCoroutine ("TriggerWithDelay", delay);
	}

	IEnumerator TriggerWithDelay (float delay) {
		yield return new WaitForSeconds (delay);
		Trigger ();
	}
}