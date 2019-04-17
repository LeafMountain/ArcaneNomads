using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputComponent : MonoBehaviour
{
    public InputKey[] Keys;
    public InputDirection[] Directions;

    void Update()
    {
        for (int i = 0; i < Keys.Length; i++)
        {
            InputKey key = Keys[i];
            if (Input.GetKeyDown(key.Name)) key.OnPressed.Invoke();
            else if (Input.GetKeyUp(key.Name)) key.OnReleased.Invoke();
            if (Input.GetKey(key.Name)) key.OnHold.Invoke();
        }

        for (int i = 0; i < Directions.Length; i++)
        {
            Directions[i].OnDirection.Invoke(new Vector2(Input.GetAxisRaw(Directions[i].HorizontalName), Input.GetAxisRaw(Directions[i].VerticalName)) * Directions[i].Sensitivity);
        }
    }
}

[System.Serializable]
public struct InputKey
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
