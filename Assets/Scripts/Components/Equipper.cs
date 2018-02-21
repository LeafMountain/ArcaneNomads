using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class Equipper : MonoBehaviour {

    public Inventory inventory;
    public Transform parent;

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

        if(meshRenderer){
            rootBone = meshRenderer.rootBone;
            bones = meshRenderer.bones;
        }
        
        Refresh();
    }

    public void Refresh() {
        Equip();
    }

    void Equip() {
        EquipItem(inventory.head, ref headSlot, parent);
        EquipItem(inventory.face, ref faceSlot, parent);
        EquipItem(inventory.chest, ref chestSlot, parent);
        EquipItem(inventory.legs, ref legsSlot, parent);

        EquipItem(inventory.rightHand, ref rightHandSlot, rightHandPosition);
        EquipItem(inventory.leftHand, ref leftHandSlot, leftHandPosition);
    }

    void Update(){
        if(refresh){
            Refresh();
            refresh = false;
        }
    }

    void EquipItem(Equipment item,  ref Transform oldItem){
        EquipItem(item, ref oldItem, transform);
    }

    void EquipItem(Equipment item,  ref Transform oldItem, Transform parent){
        if(item == null){
            return;
        }

        //Destroy old item
        if(oldItem != null){
            Destroy(oldItem);
        }

        GameObject newItem = Instantiate(item.prefab, parent.position, parent.rotation, parent);

        if(rootBone != null){
            SkinnedMeshRenderer[] meshRenderers = newItem.GetComponentsInChildren<SkinnedMeshRenderer>();

            if(meshRenderers != null){
                foreach(SkinnedMeshRenderer mr in meshRenderers){
                    mr.bones = GetNewBoneStructure(mr);
                    mr.rootBone = rootBone;
                }
            }
        }

        oldItem = newItem.transform;
    }

    Transform[] GetNewBoneStructure(SkinnedMeshRenderer mr){
        Transform[] bones = new Transform[mr.bones.Length];

        for (int i = 0; i < bones.Length; i++){
            bones[i] = FindBone(mr.bones[i].name);
        }

        return bones;
    }

    Transform FindBone(string name){
        foreach (Transform bone in bones){
            if(bone.name == name){
                return bone;
            }
        }

        return null;
    }
}
