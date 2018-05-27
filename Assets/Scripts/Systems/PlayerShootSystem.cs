using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class PlayerShootSystem : ComponentSystem 
{

	public struct Data
	{
		public PlayerInput Input;
		public WeaponSlot WeaponSlot;
	}

    protected override void OnUpdate()
    {
        foreach (var entity in GetEntities<Data>())
		{
			entity.WeaponSlot.weapon.SetActive(entity.Input.aim);
			entity.WeaponSlot.weapon.transform.LookAt(Camera.main.GetComponent<CameraComponent>().lookPosition);
		}
    }
}
