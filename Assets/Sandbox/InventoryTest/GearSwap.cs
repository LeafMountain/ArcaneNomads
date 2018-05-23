//Description: When a inventorySlot is right clicked and that slot houses a gear item, this class will swap that gear
//			   piece with the one currently equipped. If there is no gear equipped by that type the gear will just be
//			   equpped.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearSwap {

	private InventoryManager inventoryManger;
	private GearSwap(){}
	public GearSwap(InventoryManager inventoryManager, int gearIndex){
		this.inventoryManger = inventoryManager;



	}
	public void Swap(){

		
	}
}
