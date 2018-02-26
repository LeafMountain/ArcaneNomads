using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Inventory : ScriptableObject {

	public GameEvent inventoryUpdatedEvent;

	[Header("Equipment")]
	public EquipmentHead head;
    public EquipmentFace face;
    public EquipmentChest chest;
    public EquipmentLegs legs;
    public EquipmentFeet feet;

	[Header("Weapons")]
	public Equipment rightHand;
	public Equipment leftHand;
}
