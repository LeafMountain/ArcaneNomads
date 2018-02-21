using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NoiseDetector : MonoBehaviour {

    public float sensitivity;

	public UnityEvent OnHear;

    public void AddNoice(float intensity){
        if(intensity > sensitivity){
            OnHear.Invoke();
        }
    }
}
