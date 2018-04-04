using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GridArray))]
public class InventoryEditor : Editor {

	// public override void OnInspectorGUI(){
	// 	GridArray inventory = (GridArray)target;

	// 	Texture[] icons = new Texture[inventory.size.x * inventory.size.y];

	// 	GUILayout.SelectionGrid(0, icons, inventory.size.x);

	// 	DrawDefaultInspector();
	// }
	
}
