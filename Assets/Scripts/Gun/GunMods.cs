using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Gun/Mod List")]
public class GunMods : ScriptableObject {

	public GunModification magazineMod;
	public GunModification laserMod;
	public GunModification sightMod;
	public GunModification muzzleMod;
}
