using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class PlayerShootSystem : ComponentSystem
{

	public struct Data
	{
		public PlayerInput Input;
		public WeaponSlot WeaponSlot;
	}

	protected override void OnUpdate ()
	{
		foreach (var entity in GetEntities<Data> ())
		{
			// entity.WeaponSlot.weapon.SetActive (entity.Input.aim);
			entity.WeaponSlot.weapon.transform.LookAt (Camera.main.GetComponent<CameraComponent> ().lookPosition);

			Gun gun = entity.WeaponSlot.GetComponentInChildren<Gun> ();

			if (entity.Input.aim && entity.Input.fire)
			{
				gun.Trigger ();
			}

			if (entity.Input.reload)
			{
				gun.ChangeState (new GunReloading (gun));
			}
		}
	}
}