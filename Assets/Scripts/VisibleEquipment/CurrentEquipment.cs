using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Equipment/Currently Equipped List")]
public class CurrentEquipment : ScriptableObject {

	[SerializeField] private GameEvent equipmentUpdated;

	[Header ("Equipment")]
	public EquipmentHead headSlot;
	public EquipmentFace faceSlot;
	public EquipmentChest chestSlot;
	public EquipmentLegs legsSlot;
	public EquipmentBack backSlot;

	[Header ("Weapons")]
	public WeaponRange rightHand;
	public WeaponRange leftHand;

	public GunProfile gunProfile;

	public void EditHeadSlot (EquipmentHead equipment) {
		headSlot = equipment;
		UpdateEvent ();
	}
	public void EditFaceSlot (EquipmentFace equipment) {
		faceSlot = equipment;
		UpdateEvent ();
	}

	public void EditChestSlot (EquipmentChest equipment) {
		chestSlot = equipment;
		UpdateEvent ();
	}

	public void EditLegsSlot (EquipmentLegs equipment) {
		legsSlot = equipment;
		UpdateEvent ();
	}

	public void EditRightSlot (WeaponRange equipment) {
		rightHand = equipment;
		UpdateEvent ();
	}

	public void EditLeftSlot (WeaponRange equipment) {
		leftHand = equipment;
		UpdateEvent ();
	}

	public void UpdateEvent () {
		if (equipmentUpdated) {
			equipmentUpdated.Raise ();
		}
	}
}