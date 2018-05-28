using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {

	public GameObject inventoryPanel;
	public GameObject tooltipBox;
	public GameObject tooltipBoxGear;
	public GameObject mainCamera;
	public GameObject player;
	public CurrentEquipment currentEquipment;

	[Header("SFX")]
	public AudioClipContainer inventorySFXContainer;
	private AudioClip[] inventorySFXClips;

	private AudioSource inventoryAS;
	private UIToolTipBox uitooltipbox;
	private InventorySlot[] inventoryslots;
	private GearSlot[] gearSlots;
	private InventoryCameraMove inventoryCameraMove;
	private bool moveCamera;
	
	void Start () {

		uitooltipbox = new UIToolTipBox(tooltipBox, tooltipBoxGear);
		inventoryslots = inventoryPanel.GetComponentsInChildren<InventorySlot>();
		gearSlots = inventoryPanel.GetComponentsInChildren<GearSlot>();
		inventoryAS = GetComponent<AudioSource>();

		inventoryCameraMove = new InventoryCameraMove(mainCamera, player, this);
		moveCamera = false;

		if(inventoryPanel == null) inventoryPanel = transform.GetChild(0).GetChild(0).gameObject;
		if(player == null) player = Player.Instance.gameObject;
		if(mainCamera == null) mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
		if(tooltipBox == null) tooltipBox = inventoryPanel.transform.GetChild(0).gameObject;
		if(tooltipBoxGear == null) tooltipBoxGear = inventoryPanel.transform.GetChild(1).gameObject;
		
			
		inventorySFXClips = inventorySFXContainer.clip;
			
			
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyUp(KeyCode.I)){
			
			moveCamera = !moveCamera;
			
			
		}		
		inventoryCameraMove.MoveCamera(moveCamera);
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
		else if(slotItem is WeaponRange && gearSlots[4].gearItem != null){
			uitooltipbox.UpdateToolTipGear(gearSlots[4].gearItem);
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
						new GearSwap(this, 0, slot as InventorySlot);
						PlayEquipSound(5);
					}
				}
				else if(iSlot.slotItem is EquipmentFace){
					if(gearSlots[1].gearItem == null){
						new EquipGear(iSlot.slotItem, this);
						iSlot.slotItem = null;
					}
					else
					{
						new GearSwap(this, 1, slot as InventorySlot);
						PlayEquipSound(4);

					}

				}
				else if(iSlot.slotItem is EquipmentChest){
					if(gearSlots[2].gearItem == null){
						new EquipGear(iSlot.slotItem, this);
						iSlot.slotItem = null;
					}
					else
					{
						new GearSwap(this, 2, slot as InventorySlot);
						PlayEquipSound(2);
					}

				}
				else if(iSlot.slotItem is EquipmentLegs){
					if(gearSlots[3].gearItem == null){
						new EquipGear(iSlot.slotItem, this);
						iSlot.slotItem = null;
					}
					else
					{
						new GearSwap(this, 3, slot as InventorySlot);
						PlayEquipSound(3);
					}

				}
				else if(iSlot.slotItem is WeaponRange){
					if(gearSlots[4].gearItem == null){
						new EquipGear(iSlot.slotItem, this);
						iSlot.slotItem = null;
					}
					else
					{
						new GearSwap(this, 4, slot as InventorySlot);
						PlayEquipSound(6);
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
	private void PlayEquipSound(int whatClip){

        InventoryAS.clip = InventorySFXClips[whatClip];
           InventoryAS.Play();

    }

	//properties

	public InventorySlot[] InventorySlots {get{return inventoryslots;} set{inventoryslots = value;}}
	public GearSlot[] GearSlots {get{return gearSlots;} set{gearSlots = value;}}
	public UIToolTipBox uiToolTipBox{get{return uitooltipbox;}}
	public bool MoveCamera{get{return moveCamera;}set{moveCamera = value;}}
	public AudioSource InventoryAS {get{return inventoryAS;}} 
	public AudioClip[] InventorySFXClips {get{return inventorySFXClips;}}
}
