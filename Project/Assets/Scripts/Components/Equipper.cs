using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class Equipper:MonoBehaviour {

    public Inventory inventory;
    public Transform parent;

    List <GameObject> currentlyEquipped = new List <GameObject>();

    Transform headSlot;
    Transform faceSlot;
    Transform chestSlot;
    Transform legsSlot;
    Transform feetSlot;
    Transform rightHandSlot;
    Transform leftHandSlot;

    [Space]
    SkinnedMeshRenderer meshRenderer;
    Transform rootBone;
    Transform[] bones;

    [Header("Positions")]
    public Transform rightHandPosition;
    public Transform leftHandPosition;


    public bool refresh = false;

    void OnEnable() {
        meshRenderer = GetComponentInChildren<SkinnedMeshRenderer>();
        rootBone = meshRenderer.rootBone;
        bones = meshRenderer.bones;
        
        Refresh();
    }

    public void Refresh() {
        Equip();
    }

    void Equip() {
        EquipItem(inventory.head, parent, ref headSlot, rootBone);
        EquipItem(inventory.face, parent, ref faceSlot, rootBone);
        EquipItem(inventory.chest, parent, ref chestSlot, rootBone);
        EquipItem(inventory.legs, parent, ref legsSlot, rootBone);

        // EquipItem(inventory.rightHand, rightHandPosition, ref rightHandSlot);
        // EquipItem(inventory.leftHand, leftHandPosition, ref leftHandSlot);
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
                SkinnedMeshRenderer[] meshRenderer = newItem.GetComponentsInChildren<SkinnedMeshRenderer>();

                if(meshRenderer != null){
                    foreach(SkinnedMeshRenderer mr in meshRenderer){
                        Transform[] bones = new Transform[mr.bones.Length];

                        for (int i = 0; i < bones.Length; i++){
                            bones[i] = FindBone(mr.bones[i].name);
                        }

                        mr.bones = bones;
                        mr.rootBone = bone;
                    }
                }
            }

            oldItem = newItem.transform;
        }
    }

    Transform FindBone(string name){
        foreach (var item in GetComponentInChildren<SkinnedMeshRenderer>().bones){
            if(item.name == name){
                return item;
            }
        }

        return null;
    }
}
