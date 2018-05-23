using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using XInputDotNetPure;

public class InputMapper : MonoBehaviour {
	public InputAxis[] axes;
	public InputButton[] buttons;

	public UnityEvent OnRightTrigger;

	public GamePad pad;

	void Update(){
		float rightTrigger = GamePad.GetState(PlayerIndex.One).Triggers.Right;

		// if(rightTrigger > 0) {
		// 	XInputDotNetPure.GamePad.SetVibration(PlayerIndex.One, .2f, .2f);
		// 	OnRightTrigger.Invoke();
		// } else {
		// 	XInputDotNetPure.GamePad.SetVibration(PlayerIndex.One, 0, 0);
		// }

		

		for (int i = 0; i < axes.Length; i++){
			axes[i].Update("");
		}

		for (int i = 0; i < buttons.Length; i++){
			buttons[i].Update("");
		}
	}
}
