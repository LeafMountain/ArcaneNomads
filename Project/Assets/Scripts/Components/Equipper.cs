using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class Equipper:MonoBehaviour {

    public Inventory inventory; 

    [Header("Slot positions")]
    public Transform[] slots;

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

        for (int i = 0; i < slots.Length; i++) {

            if(inventory.items.Count > i){
                GameObject go = Instantiate(inventory.items[i].prefab);
                currentlyEquipped.Add(go);

                Transform slot = transform;

                if(slots.Length > 0 && slots[i] != null){
                    slot = slots[i];
                }

                if(slots.Length > 0){
                    go.transform.SetParent(slot);
                    go.transform.position = slot.position;
                    go.transform.rotation = slot.rotation; 
                }
                
            }
            
        }
    }

    void Update(){
        if(refresh){
            Refresh();
            refresh = false;
        }
    }
}
