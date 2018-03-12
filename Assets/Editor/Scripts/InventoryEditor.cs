using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Inventory))]
public class InventoryEditor : Editor {

	public override void OnInspectorGUI(){
		Inventory inventory = (Inventory)target;

		Texture[] icons = new Texture[inventory.size.x * inventory.size.y];

		GUILayout.SelectionGrid(0, icons, inventory.size.x);

		DrawDefaultInspector();
	}
	
}
