using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ColorInteractionResponse : MonoBehaviour, IInteractable
{
    public Color focusColor = Color.blue;
    public Color interactionColor = Color.red;

    Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    public void OnFocus()
    {
        renderer.material.color = focusColor;
    }

    public void OnInteract(InteractorComponent interactor)
    {
        renderer.material.color = interactionColor;
        Debug.Log("Interacted with color interactor");
    }

    public void OnUnfocus()
    {
    }
}
