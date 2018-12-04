using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

[CreateAssetMenu(menuName = ("Equipment/Mod/Gun"))]
public class GunModification : ScriptableObject {
	public string name;
	public GunStats stats;
	public GameObject prefab;
}
