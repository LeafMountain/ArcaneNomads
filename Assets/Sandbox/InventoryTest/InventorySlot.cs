using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot : Slot {

	public Item slotItem;
	private InventoryManager inventoryManager;
	
	void Start () {

		inventoryManager = GameObject.FindObjectOfType<InventoryManager>();
		
	}
	

	public void SendMyItem(Item slotItem){
		if(slotItem != null){
			
			inventoryManager.ShowTooltipBox(slotItem);

		}
	}
	
	public void HideTooltip(){
		inventoryManager.HideTooltipBox();
	}
	public void RightClicked(){
		inventoryManager.SlotRightClicked(this);
	}

}
