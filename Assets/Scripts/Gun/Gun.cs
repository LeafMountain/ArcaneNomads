using System.Collections; 
using System.Collections.Generic; 
using UnityEngine;

public class Gun : MonoBehaviour {

	public GunProfile profile;

	[Header("Summed Stats")]  
	public int damage; 
	public int bullets;	
	public int magazineSize;
	public float reloadSpeed; 
	public float cooldown; 
	public float lifetime; 
	public Vector2 spread; 

	[Header("Other")]
	public Transform origin; 
	public GameObject bulletPrefab; 

	[Header("Mod Slots")]

	public Transform magazineModPosition;
	public Transform laserModPosition;
	public Transform sightModPosition;
	public Transform muzzleModPosition;

	public int currentMagazine {
		get {
			magazine = profile.MagazineSize - usedBullets;
			return magazine; 
		}
	}
	public int usedBullets;
	
	[Space]
	public int magazine;	

	public bool updateStats;

	void Start() {
		FullUpdate();

		currentState = new GunReady(this);
	}

	IGunState currentState;

	public void ChangeState (IGunState newState) {
		currentState = newState;
	}

	void Update() {
		if(updateStats){
			updateStats = false;
			FullUpdate();
		}

		currentState.Update();
	}

	public void Trigger () {
		currentState.Trigger();
	}

	void FullUpdate(){
		UpdateStats();
		// PlaceMods();
	}

	void UpdateStats(){
		// Updates the properties to show in the inspector
		damage = profile.Damage;
		bullets = profile.Bullets;
		magazineSize = profile.MagazineSize;

		reloadSpeed = profile.ReloadSpeed;
		cooldown = profile.Cooldown;
		lifetime = profile.Lifetime;

		spread = profile.Spread;
	}

	void OnDrawGizmosSelected() {
		UnityEditor.Handles.color = Color.blue; 
		UnityEditor.Handles.DrawWireDisc(origin.position + origin.forward * lifetime, origin.forward, spread.x); 
	}
}
