using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {

	public GameObject inventoryPanel;
	public GameObject tooltipBox;
	public GameObject tooltipBoxGear;
	public GameObject player;
	private UIToolTipBox uitooltipbox;
	private InventorySlot[] inventoryslots;
	private GearSlot[] gearSlots;
	
	void Start () {

		uitooltipbox = new UIToolTipBox(tooltipBox, tooltipBoxGear);
		inventoryslots = inventoryPanel.GetComponentsInChildren<InventorySlot>();
		gearSlots = inventoryPanel.GetComponentsInChildren<GearSlot>();
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

		if(slotItem is Equipment) ShowTooltipBoxGear(slotItem);
	
	}
	public void ShowTooltipBoxGear(Item slotItem){	
		
		if(slotItem is EquipmentHead && gearSlots[0].gearItem != null){
			
			uitooltipbox.UpdateToolTipGear(gearSlots[0].gearItem);
			tooltipBoxGear.SetActive(true);
		}
		else if(slotItem is EquipmentFace && gearSlots[1].gearItem != null){
			uitooltipbox.UpdateToolTipGear(gearSlots[1].gearItem);
			tooltipBoxGear.SetActive(true);
		}
		else if(slotItem is EquipmentChest && gearSlots[2].gearItem != null){
			uitooltipbox.UpdateToolTipGear(gearSlots[2].gearItem);
			tooltipBoxGear.SetActive(true);
		}
		else if(slotItem is EquipmentLegs && gearSlots[3].gearItem != null){
			uitooltipbox.UpdateToolTipGear(gearSlots[3].gearItem);
			tooltipBoxGear.SetActive(true);
		}
	}
	public void HideTooltipBox(){
		tooltipBox.SetActive(false);
		tooltipBoxGear.SetActive(false);
	}
	public void SlotRightClicked(Slot slot){

		Debug.Log("Slot " + slot.ToString() + "was left clicked.");

		if(slot is InventorySlot){
			InventorySlot iSlot = slot as InventorySlot;
			if(iSlot.slotItem != null){
				if(iSlot.slotItem is EquipmentHead){
					if(gearSlots[0].gearItem == null){
						new EquipGear(iSlot.slotItem, this);
						iSlot.slotItem = null;
					}
					else
					{
						// new GearSwap()
					}
				}
				else if(iSlot.slotItem is EquipmentFace){
					if(gearSlots[1].gearItem == null){
						new EquipGear(iSlot.slotItem, this);
						iSlot.slotItem = null;
					}
					else
					{
						// new GearSwap()
					}

				}
				else if(iSlot.slotItem is EquipmentChest){
					if(gearSlots[2].gearItem == null){
						new EquipGear(iSlot.slotItem, this);
						iSlot.slotItem = null;
					}
					else
					{
						// new GearSwap()
					}

				}
				else if(iSlot.slotItem is EquipmentLegs){
					if(gearSlots[3].gearItem == null){
						new EquipGear(iSlot.slotItem, this);
						iSlot.slotItem = null;
					}
					else
					{
						// new GearSwap()
					}

				}
			}
		}
		else if(slot is GearSlot){
			GearSlot gSlot = slot as GearSlot;
			if(gSlot.gearItem != null){
				new UnequipGear(gSlot.gearItem, this, slot as GearSlot);
			}
		}

	}

	//properties

	public InventorySlot[] InventorySlots {get{return inventoryslots;} set{inventoryslots = value;}}
	public GearSlot[] GearSlots {get{return gearSlots;} set{gearSlots = value;}}
}
