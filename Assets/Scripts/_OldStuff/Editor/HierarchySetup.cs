using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class HierarchySetup {

	static List<Object> newObjects = new List<Object>();
	
	[MenuItem("TreeBranch/Setup Hierarchy")]
    static void SetupHierarchy()
    {
		EditorGUI.BeginChangeCheck();

		CreateGameObject("Management");
		CreateGameObject("GUI");
		CreateGameObject("Cameras");
		CreateGameObject("Lights");
		CreateGameObject("World");
		CreateGameObject("Terrain", "World");
		CreateGameObject("Props", "World");
		CreateGameObject("_Dynamic");
		
		if (EditorGUI.EndChangeCheck()){
            Undo.RecordObjects(newObjects.ToArray(), "Added Hierarchy Objects");
        }
    }

	static void CreateGameObject(string name, string parent = null){
		if(!GameObject.Find(name)){
			GameObject go = new GameObject(name);
			newObjects.Add(go);

			if(parent != null){
				go.transform.SetParent(GameObject.Find(parent).transform);
			}
		}
	}
}
