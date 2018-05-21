using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Gun/Profile")]
public class GunProfile : ScriptableObject {
	public GunStats stats;
	public GunMods mods;

	// Calculated stats
	public int Damage { get { return SumInt("damage"); } }
	public int Bullets  { get { return SumInt("bullets"); } }
	public int MagazineSize  { get { return SumInt("magazineSize"); } }
	public float ReloadSpeed  { get { return SumFloat("reloadSpeed"); } }
	public float Cooldown  { get { return SumFloat("cooldown"); } }
	public float Lifetime  { get { return SumFloat("lifetime"); } }
	public Vector2 Spread  { get { return SumVector("spread"); } }

	int SumInt(string name){
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
}
