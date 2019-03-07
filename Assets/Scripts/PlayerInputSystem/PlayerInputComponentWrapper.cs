using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using XInputDotNetPure;
using Unity.Entities;

[System.Serializable]
public struct PlayerInputComponent : IComponentData{
	public Vector2 Move;
	public Vector2 Look;
	public int swapShoulder;
	public int aim;
	public int sprint;
	public int reload;
	public int fire;
	public int interact;
	public int jump;

	[Header ("Settings")]
	public float lookSensitivity;

	[Range (0, 1)] public float leftDeadZone;
	[Range (0, 1)] public float rightDeadZone;

}

[DisallowMultipleComponent]
public class PlayerInputComponentWrapper : ComponentDataProxy<PlayerInputComponent> {}