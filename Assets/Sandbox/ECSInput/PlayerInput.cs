using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using XInputDotNetPure;

public class PlayerInput : MonoBehaviour {
	public float2 Move;
	public PlayerIndex playerIndex;

	public UnityVector2Event OnMove;
}