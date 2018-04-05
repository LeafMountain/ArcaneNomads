using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualDetector : MonoBehaviour {

	[Range(0, 100)]
	public float range = 5;
	[Range(0, 360)]
	public float angle;

	public Vector3 DirFromAngle(float angleInDegrees, bool angleIsGlobal) {
		if (!angleIsGlobal) {
			angleInDegrees += transform.eulerAngles.y;
		}
		return new Vector3(Mathf.Sin(angleInDegrees * Mathf.Deg2Rad),0,Mathf.Cos(angleInDegrees * Mathf.Deg2Rad));
	}

	void OnDrawGizmos(){
		Vector3 pointA = (DirFromAngle((-angle / 2), false)) * range;
		Debug.Log(pointA);
		Vector3 pointB = DirFromAngle(angle / 2, false);

		Gizmos.color = Color.red;
		Gizmos.DrawLine(transform.position, pointA);
		Gizmos.DrawLine(transform.position, pointB);		

	}
}
