using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot : MonoBehaviour {

	public Item slotItem;
	private InventoryManager inventoryManager;
	// Use this for initialization
	void Start () {

		inventoryManager = GameObject.FindObjectOfType<InventoryManager>();
		
	}
	
	
	void Update () {
		
	}

	public void SendMyItem(){
		inventoryManager.ShowTooltipBox(slotItem);
	}
	
	public void HideTooltip(){
		inventoryManager.HideTooltipBox();
	}

}
