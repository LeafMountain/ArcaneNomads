using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class InventoryEquipped : ScriptableObject {

	public GameEvent inventoryUpdatedEvent;

	[Header("Equipment")]
	public EquipmentHead head;
    public EquipmentFace face;
    public EquipmentChest chest;
    public EquipmentLegs legs;

	[Header("Weapons")]
	public Equipment rightHand;
	public Equipment leftHand;
}
