using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusBar : MonoBehaviour {

	public IntVariable currentValue;
	public IntReference maxValue;

	private Image image;

	void Start () {
		image = GetComponent<Image> ();
	}

	void Update () {
		image.fillAmount = (float)currentValue.Value / (float)maxValue.Value;
	}
}