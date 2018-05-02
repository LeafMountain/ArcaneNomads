using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Object List")]
public class ObjectList : ScriptableObject {

	public List<GameObject> objects = new List<GameObject>();
}
