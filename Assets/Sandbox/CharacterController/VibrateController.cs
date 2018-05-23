using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;

public class VibrateController : MonoBehaviour {

	public float time = .5f;

	public void Trigger (float intensity) {
		GamePad.SetVibration(PlayerIndex.One, intensity, intensity);
		StartCoroutine(TurnOff());
	}

	IEnumerator TurnOff () {
		yield return new WaitForSeconds(time);
		GamePad.SetVibration(PlayerIndex.One, 0, 0);
	}
	
}
