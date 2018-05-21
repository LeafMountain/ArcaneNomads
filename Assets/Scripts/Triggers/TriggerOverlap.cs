using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class TriggerOverlap : MonoBehaviour {

	public LayerMask mask;

	public UnityGameObjectEvent OnTriggerEntered;
	public UnityGameObjectEvent OnTriggerExited;
	
	void OnTriggerEnter(Collider col){
		GameObject go = col.gameObject;

		if((mask & 1 << go.layer) == 1 << go.layer){
			OnTriggerEntered.Invoke(go);
		}
	}

	void OnTriggerExit(Collider col){
		GameObject go = col.gameObject;

		if(go.layer == mask) {
			OnTriggerExited.Invoke(go);
		}
	}
}
