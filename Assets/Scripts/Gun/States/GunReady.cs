using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunReady : IGunState {
	Gun gun;
	float shotTime = 0;

	public GunReady (Gun gun) {
		this.gun = gun;
	}

	public void Update () {

	}

	public void Trigger () {
		if (gun.currentMagazine <= 0) {
			gun.ChangeState (new GunEmpty (gun));
		} else {
			Shoot ();
		}
	}

	public void Shoot () {
		float timeSinceLastShot = Time.time - shotTime;

		if (timeSinceLastShot > gun.profile.Cooldown) {
			for (int i = 0; i < gun.bullets; i++) {
				GameObject go = GameObject.Instantiate (gun.bulletPrefab, gun.origin.position, Quaternion.LookRotation (ShootDirection ()));

				Bullet bullet = go.GetComponent<Bullet> ();
				bullet.SetDamage (-gun.profile.Damage);
				bullet.SetLifetime (gun.profile.Lifetime);
			}

			gun.OnShoot.Invoke ();
			shotTime = Time.time;
			gun.usedBullets++;
		}
	}

	Vector3 ShootDirection () {
		Vector3 dir = Vector3.zero;

		dir = gun.origin.forward - gun.origin.position;
		Vector3 test = new Vector3 (Random.Range (-gun.profile.Spread.x, gun.profile.Spread.x), Random.Range (-gun.profile.Spread.y, gun.profile.Spread.y), 1).normalized;

		return gun.origin.TransformDirection (test);
	}
}