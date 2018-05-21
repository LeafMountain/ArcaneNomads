using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIToolTipBox {

	private GameObject tooltipBox;
	private Item item;
	
	private Sprite itemTypeIcon;
	private string itemName;
	private string quality;
	private string stats;
	private string description;

	
	private UIToolTipBox(){}
	public UIToolTipBox(GameObject tooltipBox)
	{
		this.tooltipBox = tooltipBox;
	}
	
	
	
	public void UpdateToolTip (Item item) {
		this.item = item;
		itemName = item.title;
		itemTypeIcon = item.icon;
		description = item.description;
		quality = item.quality.ToString();

		Change();
	}
	public void Change()
	{
		tooltipBox.transform.GetChild(0).GetComponent<Image>().sprite = itemTypeIcon;
		tooltipBox.transform.GetChild(1).GetComponent<Text>().text = itemName;
		tooltipBox.transform.GetChild(2).GetComponent<Text>().text = quality;
		//tooltipBox.transform.GetChild(4).GetComponent<Text>().text = item.;
		tooltipBox.transform.GetChild(1).GetComponent<Text>().text = description;
		
	}
	
}
