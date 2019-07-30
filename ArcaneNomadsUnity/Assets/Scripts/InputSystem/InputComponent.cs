using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputComponent : MonoBehaviour
{
    public InputButton[] Buttons;
    public InputDirection[] Directions;

    void Update()
    {
        for (int i = 0; i < Buttons.Length; i++)
        {
            InputButton button = Buttons[i];
            if (Input.GetButtonDown(button.Name)) button.OnPressed.Invoke();
            else if (Input.GetButtonUp(button.Name)) button.OnReleased.Invoke();
            if (Input.GetButton(button.Name)) button.OnHold.Invoke();
        }

        for (int i = 0; i < Directions.Length; i++)
        {
            Directions[i].OnDirection.Invoke(new Vector2(Input.GetAxisRaw(Directions[i].HorizontalName), Input.GetAxisRaw(Directions[i].VerticalName)) * Directions[i].Sensitivity);
        }
    }
}

[System.Serializable]
public struct InputButton
{
    public string Name;
    public UnityEvent OnPressed;
    public UnityEvent OnReleased;
    public UnityEvent OnHold;
}

[System.Serializable]
public struct InputDirection
{
    public string HorizontalName;
    public string VerticalName;
    public float Sensitivity;
    public UnityEventVector2 OnDirection;
}
