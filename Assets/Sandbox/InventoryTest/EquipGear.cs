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
          PlayEquipSound(5);
           
       }
       else if(equipingGear is EquipmentFace){
           inventoryManager.GearSlots[1].gearItem = equipingGear;
           PlayEquipSound(4);
       }
        else if(equipingGear is EquipmentChest){
           inventoryManager.GearSlots[2].gearItem = equipingGear;
           PlayEquipSound(2);
       }
        else if(equipingGear is EquipmentLegs){
           inventoryManager.GearSlots[3].gearItem = equipingGear;
           PlayEquipSound(3);
       }
        else if(equipingGear is WeaponRange){
            inventoryManager.GearSlots[4].gearItem = equipingGear;
            PlayEquipSound(6);
        }

        inventoryManager.HideTooltipBox();

        new UpdateCurrentGear(inventoryManager);

    }
    private void PlayEquipSound(int whatClip){

        inventoryManager.InventoryAS.clip = inventoryManager.inventorySFXClips[whatClip];
           inventoryManager.InventoryAS.Play();

    }


}
