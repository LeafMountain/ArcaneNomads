using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour {

	public UnityEvent OnInteract;
	public UnityEvent OnFocus;
	public UnityEvent OnUnFocus;

	public void Interact(){
		OnInteract.Invoke();
	}

	public void Focus(){
		OnFocus.Invoke();
	}

	public void UnFocus(){
		OnUnFocus.Invoke();
	}
}
