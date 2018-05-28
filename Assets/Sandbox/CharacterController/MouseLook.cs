using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {

	public LayerMask layer;

	public UnityVector2Event OnMouseLook;
	public Camera cam;

	Vector3? WorldPosition {
		get {
			return Hit?.point;
		}
	}

	RaycastHit? Hit {
		get {
			Ray mouseRay = cam.ScreenPointToRay (Input.mousePosition);
			RaycastHit mouseHit;

			if (Physics.Raycast (mouseRay, out mouseHit, Mathf.Infinity, layer)) {
				return mouseHit;
			}

			return null;
		}
	}

	bool Moving {
		get {
			Vector2 movement = new Vector2 (Input.GetAxis ("Mouse X"), Input.GetAxis ("Mouse Y"));

			return movement != Vector2.zero;
		}
	}

	void Start () {
		cam = Camera.main;
	}

	Vector2 DirectionToGameObject () {
		Vector3 angleBetweenMouseAndObject = (Vector3) Hit?.point - transform.position;
		// angleBetweenMouseAndObject.Normalize();

		angleBetweenMouseAndObject = Camera.main.transform.InverseTransformDirection (angleBetweenMouseAndObject);

		Vector2 dir2D = new Vector2 (angleBetweenMouseAndObject.x, angleBetweenMouseAndObject.z);

		return dir2D;
	}

	void Update () {
		if (Moving) {
			OnMouseLook.Invoke (DirectionToGameObject ());
		}
	}
}