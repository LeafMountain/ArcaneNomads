using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ColorInteractionResponse : MonoBehaviour, IInteractable
{
    public Color focusColor = Color.blue;
    public Color interactionColor = Color.red;

    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    public void OnFocus(InteractorComponent interactor)
    {
        rend.material.color = focusColor;
    }

    public void OnInteract(InteractorComponent interactor)
    {
        rend.material.color = interactionColor;
        Debug.Log("Interacted with color interactor");
    }

    public void OnUnfocus(InteractorComponent interactor)
    {
    }
}
