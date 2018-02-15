using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class Equipper:MonoBehaviour {

    public Inventory inventory;

    List <GameObject> currentlyEquipped = new List <GameObject>();

    public Transform headSlot;
    public Transform faceSlot;
    public Transform chestSlot;
    public Transform legsSlot;
    public Transform feetSlot;
    public Transform rightHandSlot;
    public Transform leftHandSlot;

    [Space]
    public Transform headBone;
    public Transform faceBone;
    public Transform chestBone;
    public Transform legsBone;
    public Transform feetBone;


    [Header("Positions")]
    public Transform rightHandPosition;
    public Transform leftHandPosition;

    public bool refresh;

    void OnEnable() {
        Refresh();
    }

    public void Refresh() {
        Equip();
    }

    void Equip() {

        EquipItem(inventory.head, transform, ref headSlot, headBone);
        EquipItem(inventory.face, transform, ref faceSlot, faceBone);
        EquipItem(inventory.chest, transform, ref chestSlot, chestBone);
        EquipItem(inventory.legs, transform, ref legsSlot, legsBone);
        EquipItem(inventory.feet, transform, ref feetSlot, feetBone);

        EquipItem(inventory.rightHand, rightHandPosition, ref rightHandSlot);
        EquipItem(inventory.leftHand, leftHandPosition, ref leftHandSlot);
    }

    void Update(){
        if(refresh){
            Refresh();
            refresh = false;
        }
    }

    void EquipItem(Equipment item, Transform parent, ref Transform oldItem, Transform bone = null){
        if(item != null){

            GameObject newItem;
            
            if(oldItem != null){
                Destroy(oldItem);
            }

            newItem = Instantiate(item.prefab, parent.position, parent.rotation, parent);

            if(bone != null){
                SkinnedMeshRenderer meshRenderer = newItem.GetComponent<SkinnedMeshRenderer>();

                if(meshRenderer){
                    meshRenderer.rootBone = bone;
                }
            }

            oldItem = newItem.transform;
        }
    }
}
