using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleTest : MonoBehaviour {

	public Vector3 heading;
	public Vector3 velocity;
	public float length;
	public float offsetAngle;

	// Use this for initialization
	void Start () {
		
	}

	Vector3 SetMagnitude(Vector3 vector){
		return vector.normalized * length;
	}

	void OnDrawGizmos(){
		Vector3 offset = Quaternion.Euler(0, offsetAngle, 0) * heading;

		offset = SetMagnitude(offset);
		heading = SetMagnitude(heading);


		Debug.DrawRay(transform.position, offset, Color.magenta);
		Debug.DrawRay(transform.position, heading);
	}
	
}
