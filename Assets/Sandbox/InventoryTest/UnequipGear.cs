using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnequipGear {

	private InventoryManager inventoryManager;
	private Item unequipingGear;

	private UnequipGear(){}
	public UnequipGear(Item unequipingGear, InventoryManager inventoryManager, GearSlot slotClicked){

		this.inventoryManager = inventoryManager;
		this.unequipingGear = unequipingGear;

		foreach(InventorySlot slot in inventoryManager.InventorySlots){
			if(slot.slotItem == null) {
				slot.slotItem = unequipingGear;
				slotClicked.gearItem = null;
				inventoryManager.HideTooltipBox();
				new UpdateCurrentGear(inventoryManager);

				PlayUnequipSound();



				break;
			}
		}

	}
	private void PlayUnequipSound(){

		inventoryManager.InventoryAS.clip = inventoryManager.inventorySFXClips[7];
		inventoryManager.InventoryAS.Play();

	}
}
