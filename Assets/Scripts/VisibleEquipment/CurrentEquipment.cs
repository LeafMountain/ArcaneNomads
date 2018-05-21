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
	public Equipment rightHand;
	public Equipment leftHand;

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

	public void EditRightSlot (Equipment equipment) {
		rightHand = equipment;
	}

	public void EditLeftSlot (Equipment equipment) {
		leftHand = equipment;
	}
}