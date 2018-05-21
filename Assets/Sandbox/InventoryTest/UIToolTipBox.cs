using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIToolTipBox {
	private Item item;
	private Sprite itemTypeIcon;
	private string itemName;
	private string quality;
	private string stats;
	private string description;

	
	private UIToolTipBox(){}
	public UIToolTipBox(Item item){
		
	}
	
	
	// Update is called once per frame
	void UpdateToolTip () {
		
		itemName = item.title;
		itemTypeIcon = item.icon;
		
	}
}
