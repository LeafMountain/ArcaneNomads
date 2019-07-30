using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Weapon))]
public class WeaponEditor : Editor
{
    private void OnSceneGUI()
    {
        Weapon weapon = (Weapon) target;
        Transform transform = weapon.transform;
        
        if(Event.current.type == EventType.Repaint)
        {
            Handles.color = Color.blue;
            Handles.ConeHandleCap(0, transform.position, transform.rotation, weapon.bulletSpeed, EventType.Repaint);
        }
        
        Handles.RadiusHandle(transform.rotation, transform.position, weapon.bulletSpeed, false);
        
        // Debug.Log("Hej");
    }
}
