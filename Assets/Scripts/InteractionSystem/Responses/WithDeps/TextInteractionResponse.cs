using TMPro;
using UnityEngine;

public class TextInteractionResponse : MonoBehaviour, IInteractable
{
    public string FocusText = "";
    public string InteractText = "";

    GameObject canvas;
    GameObject uiText;
    Camera cam;

    void Start()
    {
        cam = FindObjectOfType<Camera>();
        canvas = new GameObject("Canvas", typeof(Canvas));
        canvas.transform.SetParent(transform, false);
        canvas.GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceOverlay;
    }

    void Update()
    {
        if(uiText)
            uiText.transform.position = cam.WorldToScreenPoint(transform.position);
    }

    void CreateText(string text)
    {
        uiText = new GameObject();
        uiText.transform.SetParent(canvas.transform, false);
        var textMesh = uiText.AddComponent<TextMeshProUGUI>();
        textMesh.text = text;
        textMesh.outlineWidth = .3f;
        textMesh.fontSize = 20f;
    }

    public void OnFocus(InteractorComponent interactor)
    {
        CreateText(FocusText);
    }

    public void OnInteract(InteractorComponent interactor)
    {
        if(uiText)
            Destroy(uiText);
        CreateText(InteractText);
    }

    public void OnUnfocus(InteractorComponent interactor)
    {
        if(uiText)
            Destroy(uiText);
    }
}
