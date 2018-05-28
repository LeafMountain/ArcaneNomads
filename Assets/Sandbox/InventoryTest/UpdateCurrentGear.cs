using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateCurrentGear
{

	private InventoryManager inventoryManager;

	private UpdateCurrentGear () { }
	public UpdateCurrentGear (InventoryManager inventoryManager)
	{

		this.inventoryManager = inventoryManager;

		inventoryManager.currentEquipment.EditHeadSlot (
			inventoryManager.GearSlots[0].gearItem as EquipmentHead);

		inventoryManager.currentEquipment.EditFaceSlot (
			inventoryManager.GearSlots[1].gearItem as EquipmentFace);

		inventoryManager.currentEquipment.EditChestSlot (
			inventoryManager.GearSlots[2].gearItem as EquipmentChest);

		inventoryManager.currentEquipment.EditLegsSlot (
			inventoryManager.GearSlots[3].gearItem as EquipmentLegs);

		// inventoryManager.currentEquipment.EditRightSlot(
		// 	inventoryManager.GearSlots[4].gearItem as WeaponRange);

	}

}