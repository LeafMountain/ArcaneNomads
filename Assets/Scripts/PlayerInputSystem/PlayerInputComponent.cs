﻿using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using XInputDotNetPure;

public class PlayerInputComponent : MonoBehaviour{
	public Vector2 Move;
	public Vector2 Look;
	public bool swapShoulder;
	public bool aim;
	public bool sprint;
	public bool reload;
	public bool fire;
	public bool interact;

	[Header ("Settings")]
	public float lookSensitivity;

	[Range (0, 1)] public float leftDeadZone;
	[Range (0, 1)] public float rightDeadZone;

}