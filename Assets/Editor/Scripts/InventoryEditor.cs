using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Inventory))]
public class InventoryEditor : Editor {

	public override void OnInspectorGUI(){
		Inventory inventory = (Inventory)target;

		string[] test = new string[10];
		GUILayout.SelectionGrid(0, test, 10);

		DrawDefaultInspector();
	}
	
}
