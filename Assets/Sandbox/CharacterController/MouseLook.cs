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
		Vector3 dir = Hit.point - transform.position + Camera.main.transform.forward;
		dir.Normalize();

		Debug.Log(dir + " " + Camera.main.transform.forward);

		Vector2 dir2D = new Vector2(dir.x, dir.z);
		
		return dir2D;
	}

	void Update(){
		if(Moving){
			OnMouseLook.Invoke(DirectionToGameObject());
		}
	}

	void OnDrawGizmos(){
		Gizmos.DrawSphere(Hit.point, 0.3f);

		Gizmos.color = Color.green;
		Gizmos.DrawLine(transform.position, transform.position + new Vector3(DirectionToGameObject().x, 0, DirectionToGameObject().y));

		Gizmos.color = Color.blue;
		Gizmos.DrawRay(transform.position, new Vector3(DirectionToGameObject().x, 0, DirectionToGameObject().y) - Camera.main.transform.forward);
		
	}
}
