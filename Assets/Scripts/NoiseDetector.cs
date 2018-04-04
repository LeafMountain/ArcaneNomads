using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NoiseDetector : MonoBehaviour {

	public UnityEvent OnHear;

    public void AddNoice(Vector3 position){
        Debug.DrawLine(transform.position, position, Color.blue, .5f);
        OnHear.Invoke();
    }
}
