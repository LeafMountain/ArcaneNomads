using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipGear{

    private Item equipingGear;
    private InventoryManager inventoryManager;

    private EquipGear(){}
    public EquipGear(Item equipingGear, InventoryManager inventoryManager){
    
       this.equipingGear = equipingGear;
       this.inventoryManager = inventoryManager;

       if(equipingGear is EquipmentHead){
           inventoryManager.GearSlots[0].gearItem = equipingGear;
           
       }
       else if(equipingGear is EquipmentFace){
           inventoryManager.GearSlots[1].gearItem = equipingGear;
       }
        else if(equipingGear is EquipmentChest){
           inventoryManager.GearSlots[2].gearItem = equipingGear;
       }
        else if(equipingGear is EquipmentLegs){
           inventoryManager.GearSlots[3].gearItem = equipingGear;
       }
        else if(equipingGear is WeaponRange){
            inventoryManager.GearSlots[4].gearItem = equipingGear;
        }

        inventoryManager.HideTooltipBox();

        new UpdateCurrentGear(inventoryManager);

    }


}
