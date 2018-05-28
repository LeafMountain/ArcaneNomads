using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBar : MonoBehaviour {

	public IntVariable maxHP;
	public IntVariable currentHP;

	public Image bar;

	void Update()
	{
		bar.fillAmount = (float)(currentHP.Value/maxHP.Value);
	}


}
