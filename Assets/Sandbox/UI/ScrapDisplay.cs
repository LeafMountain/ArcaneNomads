using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrapDisplay : MonoBehaviour {

	public IntVariable scrapCounter;
	public Text text;

	void Update () {
		text.text = scrapCounter.Value.ToString();
	}
}
