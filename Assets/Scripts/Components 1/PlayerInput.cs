using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using XInputDotNetPure;

public class PlayerInput : MonoBehaviour {
	public Vector2 Move;
	public Vector2 Look;

	public PlayerIndex playerIndex;

	[Range(0, 1)]public float leftDeadZone;
	[Range(0, 1)]public float rightDeadZone;
	
}