using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class Equipper:MonoBehaviour {

    public Inventory inventory;

    // [Header("Slot positions")]
    // public Transform[] slots;

    // //Not used currently
    // public Transform Head;
    // public Transform Face;
    // public Transform Chest;
    // public Transform Legs;
    // public Transform Feet;

    List <GameObject> currentlyEquipped = new List < GameObject > ();

    public bool refresh;

    void OnEnable() {
        Refresh();
    }

    public void Refresh() {
        Equip();
    }

    void Equip() {
        foreach (GameObject go in currentlyEquipped) {
            Destroy(go); 
        }

        currentlyEquipped.Clear(); 

        EquipItem(inventory.Head, transform);
        EquipItem(inventory.Face, transform);
        EquipItem(inventory.Chest, transform);
        EquipItem(inventory.Legs, transform);
        EquipItem(inventory.Feet, transform);
    }

    void Update(){
        if(refresh){
            Refresh();
            refresh = false;
        }
    }

    void EquipItem(InventoryItem item, Transform parent){
        if(item != null){
            GameObject newItem = Instantiate(item.prefab, parent, false);
            currentlyEquipped.Add(newItem);
        }
    }
}
