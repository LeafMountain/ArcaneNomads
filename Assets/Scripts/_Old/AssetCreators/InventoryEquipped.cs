using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu]
public class InventoryEquipped : ScriptableObject {

	public GameEvent inventoryUpdatedEvent;
	private EventHandler OnInventoryUpdated;

	[Header("Equipment")]
	public EquipmentHead head;
    public EquipmentFace face;
    public EquipmentChest chest;
    public EquipmentLegs legs;

	[Header("Weapons")]
	public Equipment rightHand;
	public Equipment leftHand;

	public void EditChestSlot(EquipmentChest equipment){
		chest = equipment;

		if(OnInventoryUpdated != null){
			OnInventoryUpdated.Invoke(this, null);
		}
	}
}
