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
	private int usedBullets;
	
	[Space]
	public int magazine;	

	public bool updateStats;
	float shotTime = 0;	

	enum State { ready, reloading }
	State state;

	void Start() {
		stats = new GunStats[numberOfMods + 1];
		
		FullUpdate();
	}

	void Update() {
		if(updateStats){
			updateStats = false;
			FullUpdate();
		}
	}

	void FullUpdate(){
		UpdateComponentsList();
		UpdateStats();
		PlaceMods();
	}

	void UpdateStats(){
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


	public void Shoot() {
		float timeSinceLastShot = Time.time - shotTime;

		if(usedBullets >= MagazineSize && state != State.reloading){
			Reload();
		}
		else if(state == State.ready && timeSinceLastShot > cooldown){
			for (int i = 0; i < bullets; i++) {
				GameObject go = Instantiate(bulletPrefab, origin.position, Quaternion.LookRotation(ShootDirection()));
				
				Bullet bullet = go.GetComponent<Bullet>();
				bullet.SetDamage(-Damage); 				
				bullet.SetLifetime(Lifetime);
			}

			shotTime = Time.time;
			usedBullets ++;
		}
	}

	public void Reload(){
		state = State.reloading;
		Debug.Log("Reloading");
		StartCoroutine(ReloadTimed(ReloadSpeed));
	}

	IEnumerator ReloadTimed(float time){
		yield return new WaitForSeconds(time);
		usedBullets = 0;
		state = State.ready;
	}

	Vector3 ShootDirection() {
		Vector3 dir = Vector3.zero; 

		dir = origin.forward - origin.position;
		Vector3 test = new Vector3(Random.Range( - spread.x, spread.x), Random.Range( - spread.y, spread.y), 1).normalized; 

		return origin.TransformDirection(test); 
	}

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

		// UnityEditor.Handles.color = Color.red; 
		// for (int i = 0; i < bullets; i++) {
		// 	UnityEditor.Handles.DrawLine(origin.position, origin.position + ShootDirection() * lifetime); 
		// }
	}
}