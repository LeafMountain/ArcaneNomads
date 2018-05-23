using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GearSlotType {head, face, body, legs, Length}
public class GearSlot : Slot{

	public Item gearItem;
	public GearSlotType type;
	private InventoryManager inventoryManager;

	void Start () {

		inventoryManager = GameObject.FindObjectOfType<InventoryManager>();
		
	}

	public void SendMyItem(){
		if(gearItem != null) inventoryManager.ShowTooltipBoxGear(gearItem);
	}
	
	public void HideTooltip(){
		inventoryManager.HideTooltipBox();
	}
	
}
