using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Stat : MonoBehaviour {
    protected string title;

    public IntVariable currentValue;
    public IntReference maxValue;
    public bool resetOnPlay = true;

    public UnityEvent OnDecrease;
    public UnityEvent OnIncrease;
    public UnityEvent OnEmpty;

    void Awake () {
        if (resetOnPlay) {
            Reset ();
        }
    }

    public void ModifyValue (int amount) {
        currentValue.ApplyChange (amount);

        if (amount > 0) {
            OnIncrease.Invoke ();
        } else {
            OnDecrease.Invoke ();
        }

        if (currentValue.Value <= 0) {
            currentValue.SetValue (0);
            OnEmpty.Invoke ();
        }
    }

    public void Reset () {
        if (!currentValue) {
            currentValue = ScriptableObject.CreateInstance<IntVariable> ();
            currentValue.name = gameObject.name + " " + title;
        }
        currentValue.SetValue (maxValue.Value);
    }
}