using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LerpComponent : MonoBehaviour
{
    public float direction;
    public float speed;
    public UnityEventFloat OnLerp;

    float current;
    Animator animator;

    public void ToggleDirection()
    {
        direction *= -1;
    }

    void Update()
    {
        current += direction * Time.deltaTime * speed;
        current = Mathf.Clamp01(current);
        GetComponent<Animator>().SetFloat("height", current);
    }
}

[System.Serializable]
public class UnityEventFloat : UnityEvent<float> {}
