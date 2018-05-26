using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using XInputDotNetPure;

public class PlayerInputSystem : ComponentSystem 
{

	public struct PlayerData 
	{
		public PlayerInput Input;
	}

	protected override void OnUpdate () 
	{
		foreach (var entity in GetEntities<PlayerData> ()) 
		{
			Vector2 move = new float2();
			Vector2 look = new float2();

			move += XInputMove(entity.Input.playerIndex);
			look += XInputLook(entity.Input.playerIndex);

			move += UnityMove();
			look += UnityLook();

			float moveMagnitude = move.magnitude;
			float lookMagnitude = move.magnitude;

			if(entity.Input.leftDeadZone > moveMagnitude)
			{
				move = Vector2.zero;
			}
			else if(moveMagnitude > 1)
			{
				move = math.normalize (move);
			}
			
			if(entity.Input.rightDeadZone > lookMagnitude)
			{
				look = Vector2.zero;
			}
			else if(lookMagnitude > 1) 
			{
				look = math.normalize (look);	
			}

			entity.Input.Move = move;
			entity.Input.Look = look;
		}
	}

	Vector2 UnityMove ()
	{
		float2 input;

		input.x = Input.GetAxis ("Horizontal");
		input.y = Input.GetAxis ("Vertical");

		return input;
	}

	Vector2 UnityLook ()
	{
		float2 input;

		input.x = Input.GetAxis ("Mouse X");
		input.y = Input.GetAxis ("Mouse Y");

		return input;
	}

	Vector2 XInputMove (PlayerIndex index) 
	{
		float2 input;

		input.x = GamePad.GetState (index).ThumbSticks.Left.X;
		input.y = GamePad.GetState (index).ThumbSticks.Left.Y;

		return input;
	}

	Vector2 XInputLook (PlayerIndex index) 
	{
		float2 input;

		input.x = GamePad.GetState (index).ThumbSticks.Right.X;
		input.y = GamePad.GetState (index).ThumbSticks.Right.Y;

		return input;
	}
}