using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Statistics/Gun")]
public class GunStats : ScriptableObject {
	public int damage;	
	public int magazineSize;
	public int bullets;
	public float reloadSpeed; 
	public float cooldown; 
	public float lifetime; 
	public Vector2 spread; 
}
