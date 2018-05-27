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
			Vector2 move = Move();
			Vector2 look = Look();

			entity.Input.Move = move;
			entity.Input.Look = look;
			entity.Input.swapShoulder = SwapShoulder();
			entity.Input.aim = Aim();
			entity.Input.sprint = Sprint();
		}
	}

	Vector2 Move ()
	{
		Vector2 move = UnityMove() + XInputMove(PlayerIndex.One);
		return move;
	}

	Vector2 Look ()
	{
		Vector2 look = UnityLook() + XInputLook(PlayerIndex.One);
		return look;
	}

	bool Aim ()
	{
		return UnityAim() || XInputAim();
	}

	bool Sprint ()
	{
		return UnitySprint();
	}

	bool UnitySprint ()
	{
		return Input.GetKey(KeyCode.LeftShift);
	}

	bool UnityAim ()
	{
		return Input.GetButton("Aim");
	}

	bool XInputAim ()
	{
		return GamePad.GetState(PlayerIndex.One).Triggers.Left > 0;
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

	bool SwapShoulder ()
	{
		return Input.GetKeyDown(KeyCode.V);
	}
}