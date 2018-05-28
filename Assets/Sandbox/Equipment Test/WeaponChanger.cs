using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponChanger : MonoBehaviour
{

	public CurrentEquipment CurrentEquipment;
	public GunProfile weapon;
	public Transform spawnPos;

	void Start ()
	{
		GameObject gun = weapon.GetGameObject ();
		gun.transform.position = spawnPos.position;
		gun.transform.rotation = spawnPos.rotation;
	}

	public void Trigger ()
	{
		CurrentEquipment.EditRightSlot (weapon);
	}

}