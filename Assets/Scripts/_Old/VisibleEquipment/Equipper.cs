﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipper : MonoBehaviour {

    public CurrentEquipment currentSetup;
    public GameEvent equipmentChanged;

    [SerializeField] private Transform parent;

    [Header ("Positions")]
    [SerializeField] private Transform backSlotPosition;
    [SerializeField] private Transform rightHandPosition;
    [SerializeField] private Transform leftHandPosition;

    Transform headSlot;
    Transform faceSlot;
    Transform chestSlot;
    Transform legsSlot;
    Transform backSlot;
    Transform rightHandSlot;
    Transform leftHandSlot;

    [Space]
    SkinnedMeshRenderer meshRenderer;
    Transform rootBone;
    Transform[] bones;

    public bool refresh = false;

    void OnEnable () {
        meshRenderer = GetComponentInChildren<SkinnedMeshRenderer> ();

        if (meshRenderer) {
            rootBone = meshRenderer.rootBone;
            bones = meshRenderer.bones;
        }

        Refresh ();
        equipmentChanged.AddListener (() => Refresh ());
    }

    public void Refresh () {
        Equip ();
    }

    void Equip () {
        if (!currentSetup) {
            return;
        }

        EquipItem (currentSetup.headSlot, ref headSlot, parent);
        EquipItem (currentSetup.faceSlot, ref faceSlot, parent);
        EquipItem (currentSetup.chestSlot, ref chestSlot, parent);
        EquipItem (currentSetup.legsSlot, ref legsSlot, parent);

        EquipItem (currentSetup.backSlot, ref backSlot, backSlotPosition);

        EquipWeapon (currentSetup.gunProfile);

        // EquipItem (currentSetup.rightHand, ref rightHandSlot, rightHandPosition);
        // EquipItem (currentSetup.leftHand, ref leftHandSlot, leftHandPosition);
    }

    void Update () {
        if (refresh) {
            Refresh ();
            refresh = false;
        }
    }

    void EquipItem (Equipment item, ref Transform oldItem) {
        EquipItem (item, ref oldItem, transform);
    }

    void EquipWeapon (GunProfile gun) {
        if (rightHandSlot) {
            Destroy (rightHandSlot.gameObject);
        }

        GameObject go = gun.GetGameObject ();
        go.transform.position = rightHandPosition.position;
        go.transform.rotation = rightHandPosition.rotation;
        go.transform.SetParent (rightHandPosition);
        rightHandSlot = go.transform;
    }

    void EquipItem (Equipment item, ref Transform oldItem, Transform parent) {
        if (item == null) {
            return;
        }

        //Destroy old item
        if (oldItem != null) {
            Destroy (oldItem.gameObject);
        }

        GameObject newItem = Instantiate (item.prefab, parent.position, parent.rotation, parent);

        if (rootBone != null) {
            SkinnedMeshRenderer[] meshRenderers = newItem.GetComponentsInChildren<SkinnedMeshRenderer> ();

            if (meshRenderers != null) {
                foreach (SkinnedMeshRenderer mr in meshRenderers) {
                    mr.bones = GetNewBoneStructure (mr);
                    mr.rootBone = rootBone;
                }
            }
        }

        oldItem = newItem.transform;
    }

    Transform[] GetNewBoneStructure (SkinnedMeshRenderer mr) {
        Transform[] bones = new Transform[mr.bones.Length];

        for (int i = 0; i < bones.Length; i++) {
            bones[i] = FindBone (mr.bones[i].name);
        }

        return bones;
    }

    Transform FindBone (string name) {
        foreach (Transform bone in bones) {
            if (bone.name == name) {
                return bone;
            }
        }

        return null;
    }
}