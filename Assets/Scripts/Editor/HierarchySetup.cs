using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class HierarchySetup {

	[MenuItem("TreeBranch/Setup Hierarchy")]
    static void SetupHierarchy()
    {
		CreateGameObject("Management");
		CreateGameObject("GUI");
		CreateGameObject("Cameras");
		CreateGameObject("Lights");
		CreateGameObject("World");
		CreateGameObject("Terrain", "World");
		CreateGameObject("Props", "World");
		CreateGameObject("_Dynamic");
    }

	static void CreateGameObject(string name, string parent = null){
		if(!GameObject.Find(name)){
			GameObject go = Object.Instantiate(new GameObject(name));

			if(parent != null){
				go.transform.SetParent(GameObject.Find(parent).transform);
			}
		}
	}
}
