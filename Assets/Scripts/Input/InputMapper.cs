using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMapper : MonoBehaviour {
	public InputAxis[] axes;
	public InputButton[] buttons;

	void Update(){
		for (int i = 0; i < axes.Length; i++){
			axes[i].Update("");
		}

		for (int i = 0; i < buttons.Length; i++){
			buttons[i].Update("");
		}
	}
}
