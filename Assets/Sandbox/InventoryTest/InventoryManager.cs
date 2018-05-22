﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {

	public GameObject inventoryPanel;
	public GameObject tooltipBox;
	public GameObject player;
	private UIToolTipBox uitooltipbox;
	private InventorySlot[] slots;
	
	void Start () {

		uitooltipbox = new UIToolTipBox(tooltipBox);
		slots = inventoryPanel.GetComponentsInChildren<InventorySlot>();
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyUp(KeyCode.I)){
			inventoryPanel.SetActive(!inventoryPanel.activeSelf);

		}		
	}
	public void ShowTooltipBox(Item slotItem){

		uitooltipbox.UpdateToolTip(slotItem);
		tooltipBox.SetActive(true);
		
	}
	public void HideTooltipBox(){
		tooltipBox.SetActive(false);
	}

}
