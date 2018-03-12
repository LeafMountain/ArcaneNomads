using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : ScriptableObject {

	public string title;
	public Sprite icon;
	public GameObject prefab;
	public Vector2 size = new Vector2(1,1);
	
}
