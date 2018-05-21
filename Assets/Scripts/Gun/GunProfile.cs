using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Gun/Profile")]
public class GunProfile : ScriptableObject {

	public WeaponRange gun;
	public GunMods mods;

	// Calculated stats
	public int Damage { get { return SumInt("damage"); } }
	public int Bullets  { get { return SumInt("bullets"); } }
	public int MagazineSize  { get { return SumInt("magazineSize"); } }
	public float ReloadSpeed  { get { return SumFloat("reloadSpeed"); } }
	public float Cooldown  { get { return SumFloat("cooldown"); } }
	public float Lifetime  { get { return SumFloat("lifetime"); } }
	public Vector2 Spread  { get { return SumVector("spread"); } }

	public GameObject GetGameObject () {
		GameObject gunGo = Instantiate(this.gun.prefab);
		Gun gun = gunGo.GetComponent<Gun>();

		gun.profile = this;

		if(mods.muzzleMod) SimpleInstantiate(mods.muzzleMod.prefab, gun.muzzleModPosition);
		if(mods.laserMod) SimpleInstantiate(mods.laserMod.prefab, gun.laserModPosition);
		if(mods.sightMod) SimpleInstantiate(mods.sightMod.prefab, gun.sightModPosition);
		if(mods.magazineMod) SimpleInstantiate(mods.magazineMod.prefab, gun.magazineModPosition);

		return gunGo;
	}

	void SimpleInstantiate(GameObject prefab, Transform parent) {
		Instantiate(prefab, parent.position, parent.rotation, parent);
	}

	GunStats[] GetStats() {
		GunStats[] stats = new GunStats[5];

		stats[0] = gun.baseStats;
		if(mods.laserMod) stats[1] = mods.laserMod.stats;
		if(mods.sightMod) stats[2] = mods.sightMod.stats;
		if(mods.muzzleMod) stats[3] = mods.muzzleMod.stats;
		if(mods.magazineMod) stats[4] = mods.magazineMod.stats;

		return stats;
	}

	int SumInt(string name){
		GunStats[] stats = GetStats();

		int sum = 0;
			
		for (int i = 0; i < stats.Length; i++) {
			if(stats[i] != null) {
				sum += (int)typeof(GunStats).GetField(name).GetValue(stats[i]);
			}
		}

		sum = (int)Mathf.Clamp(sum, 1, Mathf.Infinity);

	 	return sum;
	}

	float SumFloat(string name){
		GunStats[] stats = GetStats();
		
		float sum = 0;
			
		for (int i = 0; i < stats.Length; i++) {
			if(stats[i] != null) {
				sum += (float)typeof(GunStats).GetField(name).GetValue(stats[i]);
			}
		}

		sum = Mathf.Clamp(sum, 0.01f, Mathf.Infinity);

	 	return sum;
	}

	Vector2 SumVector(string name){
		GunStats[] stats = GetStats();
		
		Vector2 sum = Vector2.zero;
			
		for (int i = 0; i < stats.Length; i++) {
			if(stats[i] != null) {
				sum += (Vector2)typeof(GunStats).GetField(name).GetValue(stats[i]);
			}
		}

		sum = new Vector2(Mathf.Clamp(sum.x, 0, Mathf.Infinity), Mathf.Clamp(sum.y, 0, Mathf.Infinity));

	 	return sum;
	}
}
