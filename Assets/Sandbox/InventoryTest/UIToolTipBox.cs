using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIToolTipBox {

	private GameObject tooltipBox;
	private GameObject tooltipBoxGear;
	private Item item;
	
	private Sprite itemTypeIcon;
	private string itemName;
	private string quality;
	private string stats;
	private string description;

	
	private UIToolTipBox(){}
	public UIToolTipBox(GameObject tooltipBox, GameObject tooltipBoxGear)
	{
		this.tooltipBox = tooltipBox;
		this.tooltipBoxGear = tooltipBoxGear;
	}
	
	
	
	public void UpdateToolTip (Item item) {

		if(item != null){
		this.item = item;
		itemName = item.title;
		itemTypeIcon = item.icon;
		description = item.description;
		quality = item.quality.ToString();

		Change(tooltipBox);
		}
		else
		{
		ClearText();
		}
	}
	public void UpdateToolTipGear(Item item){

		if(item != null){
		this.item = item;
		itemName = item.title;
		itemTypeIcon = item.icon;
		description = item.description;
		quality = item.quality.ToString();

		Change(tooltipBoxGear);
		}
		else{
			ClearText();
		}
	}
	public void Change(GameObject whatBox)
	{
		GameObject box = whatBox;

		box.transform.GetChild(0).GetComponent<Image>().sprite = itemTypeIcon;
		box.transform.GetChild(1).GetComponent<Text>().text = itemName;
		box.transform.GetChild(2).GetComponent<Text>().text = quality;
		//box.transform.GetChild(4).GetComponent<Text>().text = item.;
		box.transform.GetChild(5).GetComponent<Text>().text = description;
		
	}
	
	private void ClearText(){
			itemName = "";
			itemTypeIcon = null;
			description = "";
			quality = "";
	}

}
