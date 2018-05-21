using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunReloading : IGunState {
	Gun gun;
	float reloadTimeElapsed;

	public GunReloading (Gun gun) {
		this.gun = gun;
	}

	public void Update() {
		reloadTimeElapsed += Time.deltaTime;

		if(reloadTimeElapsed >= gun.profile.ReloadSpeed){
			gun.usedBullets = 0;
			gun.ChangeState(new GunReady(gun));
		}
	}

	public void Trigger () {

	}
}