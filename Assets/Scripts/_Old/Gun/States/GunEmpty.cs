using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunEmpty : IGunState {
	Gun gun;

	public GunEmpty (Gun gun) {
		this.gun = gun;
	}

	public void Update () {

	}
	
	public void Trigger () {
		gun.ChangeState(new GunReloading(gun));
	}
}
