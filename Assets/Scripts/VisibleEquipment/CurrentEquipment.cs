using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Equipment/Currently Equipped List")]
public class CurrentEquipment : ScriptableObject {

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
	}
	public void EditFaceSlot (EquipmentFace equipment) {
		faceSlot = equipment;
	}

	public void EditChestSlot (EquipmentChest equipment) {
		chestSlot = equipment;
	}

	public void EditLegsSlot (EquipmentLegs equipment) {
		legsSlot = equipment;
	}

	public void EditRightSlot (WeaponRange equipment) {
		rightHand = equipment;
	}

	public void EditLeftSlot (WeaponRange equipment) {
		leftHand = equipment;
	}
}