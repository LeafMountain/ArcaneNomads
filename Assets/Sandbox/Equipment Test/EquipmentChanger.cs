using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentChanger : MonoBehaviour
{

	public CurrentEquipment CurrentEquipment;
	public Equipment newEquipment;

	void Start ()
	{
		Instantiate (newEquipment.prefab, transform.position, transform.rotation);
	}

	public void Trigger ()
	{
		if (newEquipment is EquipmentHead)
		{
			CurrentEquipment.EditHeadSlot ((EquipmentHead) newEquipment);
		}
		else if (newEquipment is EquipmentFace)
		{
			CurrentEquipment.EditFaceSlot ((EquipmentFace) newEquipment);
		}
		else if (newEquipment is EquipmentChest)
		{
			CurrentEquipment.EditChestSlot ((EquipmentChest) newEquipment);
		}
		else if (newEquipment is EquipmentLegs)
		{
			CurrentEquipment.EditLegsSlot ((EquipmentLegs) newEquipment);
		}
	}
}