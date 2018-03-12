using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsCast : MonoBehaviour {

	public enum CastShape { Ray, Proximity }

	public CastShape shape;
	public float range;
	public float radius;

	public UnityGameObjectEvent OnHit;
	public UnityGameObjectsEvent OnHits;

	void Update(){
		switch (shape){
			case CastShape.Ray:
				GameObject hitGo = Raycast();
				OnHit.Invoke(hitGo);
				break;
			case CastShape.Proximity:
				GameObject[] gos = Spherecast();
				OnHits.Invoke(gos);
				break;
		}
	}

	GameObject Raycast(){
		RaycastHit hit;
		Debug.DrawRay(transform.position, transform.forward * range, Color.red);
		if(Physics.Raycast(transform.position, transform.forward, out hit, range)){
			return hit.transform.gameObject;
		}
		return null;
	}

	GameObject[] Spherecast(){
		GameObject[] gos;
		RaycastHit[] hits = new RaycastHit[20];

		Physics.SphereCastNonAlloc(transform.position, radius, transform.forward, hits, range);

		gos = new GameObject[hits.Length];

		if(hits.Length > 0){		
			for (int i = 0; i < hits.Length; i++) {
				if(hits[i].collider != null){
					gos[i] = hits[i].transform.gameObject;
				}
			}
		}

		return gos;
	}

	void OnDrawGizmos(){
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, radius);
	}

}
