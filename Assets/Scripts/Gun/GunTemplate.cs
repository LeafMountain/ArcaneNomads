using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class GunTemplate {

	private int damage; 
	private int bullets; 
	private int magazineSize; 
	private float reloadSpeed; 
	private float cooldown; 
	private float lifetime; 
	private Vector2 spread; 

	public int Damage {get {return damage; }set {damage = value; }}
	public int Bullets {get {return bullets; } set {} }
	public int MagazineSize {get; set; }
	public float ReloadSpeed {get; set; }
	public float Cooldown {get; set; }
	public float Lifetime {get; set; }
	public Vector2 Spread {get; set; }
}
