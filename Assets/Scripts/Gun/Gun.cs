using System.Collections; 
using System.Collections.Generic; 
using UnityEngine;

public class Gun:MonoBehaviour {

	public int numberOfMods; 
	private GunStats[] stats; 

	public GunStats baseStats; 

	// Calculated stats
	public int Damage { get { return SumInt("damage", ref damage); } }
	public int Bullets  { get { return SumInt("bullets", ref bullets); } }
	public int MagazineSize  { get { return SumInt("magazineSize", ref magazineSize); } }
	public float ReloadSpeed  { get { return SumFloat("reloadSpeed", ref reloadSpeed); } }
	public float Cooldown  { get { return SumFloat("cooldown", ref cooldown); } }
	public float Lifetime  { get { return SumFloat("lifetime", ref lifetime); } }
	public Vector2 Spread  { get { return SumVector("spread", ref spread); } }

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

	[Header("Mods")]
	public GunModification magazineMod;
	public GunModification laserMod;
	public GunModification sightMod;
	public GunModification muzzleMod;

	[Header("Mod Slots")]

	public Transform magazineModPosition;
	public Transform laserModPosition;
	public Transform sightModPosition;
	public Transform muzzleModPosition;

	public int currentMagazine {
		get {
			magazine = MagazineSize - usedBullets;
			return magazine; 
		}
	}
	public int usedBullets;
	
	[Space]
	public int magazine;	

	public bool updateStats;

	enum State { ready, reloading }
	State state;

	void Start() {
		stats = new GunStats[numberOfMods + 1];
		
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
		UpdateComponentsList();
		UpdateStats();
		PlaceMods();
	}

	void UpdateStats(){
		// Updates the properties to show in the inspector
		var temp = Damage;
		temp = Bullets;
		temp = MagazineSize;
		var temp2 = ReloadSpeed;
		temp2 = Cooldown;
		temp2 = Lifetime;
		var temp3 = Spread;
	}

	void UpdateComponentsList() {
		int index = 0;

		stats[index] = baseStats;
		index++;

		if(magazineMod){
			stats[index] = magazineMod.stats;
			index++;
		}
		if(laserMod){
			stats[index] = laserMod.stats;
			index++;
		}
		if(sightMod){
			stats[index] = sightMod.stats;
			index++;
		}
		if(muzzleMod){
			stats[index] = muzzleMod.stats;
			index++;
		}
	}

	List<GameObject> placedMods = new List<GameObject>();

	void PlaceMods(){
		placedMods.ForEach((mod) => Destroy(mod));

		PlaceMod(magazineMod, magazineModPosition);
		PlaceMod(laserMod, laserModPosition);
		PlaceMod(sightMod, sightModPosition);
		PlaceMod(muzzleMod, muzzleModPosition);
	}

	void PlaceMod(GunModification modification, Transform slot){
		if(!modification || !slot){
			return;
		}

		placedMods.Add(Instantiate(modification.prefab, slot.position, slot.rotation, slot));
	}

	// IEnumerator ReloadTimed(float time){
	// 	yield return new WaitForSeconds(time);
	// 	usedBullets = 0;
	// 	state = State.ready;
	// }

	int SumInt(string name, ref int variable){
		int sum = 0;
			
		for (int i = 0; i < stats.Length; i++) {
			if(stats[i] != null) {
				sum += (int)typeof(GunStats).GetField(name).GetValue(stats[i]);
			}
		}

		variable = (int)Mathf.Clamp(sum, 1, Mathf.Infinity);

	 	return sum;
	}

	float SumFloat(string name, ref float variable){
		float sum = 0;
			
		for (int i = 0; i < stats.Length; i++) {
			if(stats[i] != null) {
				sum += (float)typeof(GunStats).GetField(name).GetValue(stats[i]);
			}
		}

		variable = Mathf.Clamp(sum, 0.01f, Mathf.Infinity);

	 	return sum;
	}

	Vector2 SumVector(string name, ref Vector2 variable){
		Vector2 sum = Vector2.zero;
			
		for (int i = 0; i < stats.Length; i++) {
			if(stats[i] != null) {
				sum += (Vector2)typeof(GunStats).GetField(name).GetValue(stats[i]);
			}
		}

		variable = new Vector2(Mathf.Clamp(sum.x, 0, Mathf.Infinity), Mathf.Clamp(sum.y, 0, Mathf.Infinity));

	 	return sum;
	}

	void OnDrawGizmosSelected() {
		UnityEditor.Handles.color = Color.blue; 
		UnityEditor.Handles.DrawWireDisc(origin.position + origin.forward * lifetime, origin.forward, spread.x); 
	}


}