using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour {
	
	public float visionLength = 2;

	Vector3 origin;
	Interactable focusTarget;

	void Start(){
		origin = GetComponent<Collider>().bounds.center;
	}

	RaycastHit VisionRay {
		get {
			Ray visionRay = new Ray(origin, transform.forward);
			RaycastHit visionHit;

			Physics.Raycast(visionRay, out visionHit, visionLength);

			return visionHit;
		}
	}

	void Update(){
		See();
	}

	public void See(){
		Transform visionTarget = VisionRay.transform;
		Interactable interactable = null;

		if(visionTarget){
			interactable = visionTarget.GetComponent<Interactable>();

			if(interactable && interactable != focusTarget){
				UnFocus();
				Focus(interactable);
			}
		}
		else if (focusTarget != null) {
			focusTarget.UnFocus();
			focusTarget = null;
		}
	}

	void Focus(Interactable interactable){
		interactable.Focus();
		focusTarget = interactable;
	}

	void UnFocus(){
		if(focusTarget){
			focusTarget.UnFocus();
			focusTarget = null;
		}
	}

	//Interact with the interactable the character is looking at (if it's looking at an interactable)
	public void Interact(){
		Transform visionTarget = VisionRay.transform;
		Interactable interactable = null;

		if(visionTarget){
			interactable = visionTarget.GetComponent<Interactable>();
			interactable.Interact();
		}
	}

	void OnDrawGizmos(){
		Gizmos.color = Color.blue;
		origin = GetComponent<Collider>().bounds.center;
		Gizmos.DrawLine(origin, origin + transform.forward * visionLength);
	}
}
