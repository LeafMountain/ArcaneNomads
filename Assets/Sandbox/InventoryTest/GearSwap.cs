//Description: When a inventorySlot is right clicked and that slot houses a gear item, this class will swap that gear
//			   piece with the one currently equipped. If there is no gear equipped by that type the gear will just be
//			   equpped.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearSwap {

	private InventoryManager inventoryManger;
	private Item equipingItem;
	private Item unequipingItem;
	private GearSwap(){}
	public GearSwap(InventoryManager inventoryManager, int gearIndex, InventorySlot inventoryslot){
		this.inventoryManger = inventoryManager;
		equipingItem = inventoryslot.slotItem;
		inventoryslot.slotItem = null;
		unequipingItem = inventoryManager.GearSlots[gearIndex].gearItem;

		inventoryManager.GearSlots[gearIndex].gearItem = equipingItem;

		
		foreach(InventorySlot slot in inventoryManager.InventorySlots){
			if(slot.slotItem == null)
			{
				slot.slotItem = unequipingItem;
				
				inventoryManager.uiToolTipBox.UpdateToolTip(unequipingItem);
				inventoryManager.uiToolTipBox.UpdateToolTipGear(equipingItem);
				
				new UpdateCurrentGear(inventoryManager); 

				break;
			}
		}
		
		

	}

}
