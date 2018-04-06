using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {

	public LayerMask layer;

	public UnityVector2Event OnMouseLook;

	RaycastHit Hit {
		get{
			Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit mouseHit;

			Physics.Raycast(mouseRay, out mouseHit, layer);

			return mouseHit;
		}
	}

	bool Moving {
		get {
			Vector2 movement = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
			
			return movement != Vector2.zero;
		}
	}

	Vector2 DirectionToGameObject(){
		Vector3 angleBetweenMouseAndObject = Hit.point - transform.position;
		angleBetweenMouseAndObject.Normalize();

		angleBetweenMouseAndObject = Camera.main.transform.InverseTransformDirection(angleBetweenMouseAndObject);

		Vector2 dir2D = new Vector2(angleBetweenMouseAndObject.x, angleBetweenMouseAndObject.z);
		
		return dir2D;
	}

	void Update(){
		if(Moving){
			OnMouseLook.Invoke(DirectionToGameObject());
		}
	}
}
