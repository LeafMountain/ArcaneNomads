using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class OutlineInteractionResponse : MonoBehaviour, IInteractable
{
    public Material outlineMaterial;

    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    public void OnFocus()
    {
        if(!outlineMaterial)
            return;
            
        // Add the outline material to the end of the material array
        Material[] materials = new Material[rend.materials.Length + 1];
        for (int i = 0; i < materials.Length - 1; i++)
        {
            materials[i] = rend.materials[i];
        }
        materials[materials.Length - 1] = outlineMaterial;
        rend.materials = materials;
    }

    public void OnInteract(InteractorComponent interactor)
    {

    }

    public void OnUnfocus()
    {
        if(!outlineMaterial)
            return;
            
        // Remove the last material
        Material[] materials = new Material[rend.materials.Length - 1];
        for (int i = 0; i < materials.Length; i++)
        {
            materials[i] = rend.materials[i];
        }
        rend.materials = materials;
    }
}
