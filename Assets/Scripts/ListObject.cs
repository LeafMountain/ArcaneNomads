using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListObject : MonoBehaviour {

	public ObjectList list;

	void OnEnable(){
		list.objects.Add(gameObject);
	}

	void OnDisable(){
		list.objects.Remove(gameObject);
	}
}
