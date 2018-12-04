using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpFloat : MonoBehaviour {

	public float minValue = 0;
	public float maxValue = 1;
	public float timeMultiplier = 1;
	public float currentValue;

	public UnityFloatEvent OnLerp;

	public void SetMultiplier(float newMultiplier){
		timeMultiplier = newMultiplier;
	}

	void Start(){
		currentValue = minValue;
	}

	void Update(){
		if(Mathf.Abs(minValue - maxValue) > .1f){
			currentValue = Mathf.Lerp(currentValue, maxValue, Time.deltaTime * timeMultiplier);
			OnLerp.Invoke(currentValue);
		}
	}

}
