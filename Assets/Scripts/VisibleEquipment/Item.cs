using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : ScriptableObject {

	public enum Quality { Junk, Common, Rare, Epic, Legendary }

	public string title;
	public string description;
	public Sprite icon;
	public Quality quality;

	public GameObject prefab;
	public Vector2Int size = new Vector2Int(1,1);
	
}
