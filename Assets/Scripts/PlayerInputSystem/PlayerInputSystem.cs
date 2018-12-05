using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using XInputDotNetPure;

public class PlayerInputSystem : ComponentSystem
{

	public struct InputData{
		public readonly int Length;
		public ComponentDataArray<PlayerInputComponent> components;
	}

	[Inject] InputData inputData;

	protected override void OnUpdate ()
	{
		for (int i = 0; i < inputData.Length; i++){
			PlayerInputComponent newComponent = inputData.components[i];

			Vector2 move = Move ();
			Vector2 look = Look ();

			newComponent.Move = move;
			newComponent.Look = look;
			newComponent.swapShoulder = SwapShoulder ();
			newComponent.aim = Aim ();
			newComponent.sprint = Sprint ();
			newComponent.reload = Reload ();
			newComponent.fire = Fire ();
			newComponent.interact = Interact();

			inputData.components[i] = newComponent;
		}
	}

	Vector2 Move ()
	{
		Vector2 move = UnityMove () + XInputMove (PlayerIndex.One);
		return move;
	}

	Vector2 Look ()
	{
		Vector2 look = UnityLook () + XInputLook (PlayerIndex.One);
		return look;
	}

	bool Aim ()
	{
		return UnityAim () || XInputAim ();
	}

	bool Sprint ()
	{
		return UnitySprint ();
	}

	bool Reload ()
	{
		return UnityReload ();
	}

	bool Fire ()
	{
		return Input.GetButton ("Fire");
	}

	bool UnityReload ()
	{
		return Input.GetKeyDown (KeyCode.R);
	}

	bool UnitySprint ()
	{
		return Input.GetKey (KeyCode.LeftShift);
	}

	bool UnityAim ()
	{
		return Input.GetButton ("Aim");
	}

	bool XInputAim ()
	{
		return GamePad.GetState (PlayerIndex.One).Triggers.Left > 0;
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
		return Input.GetKeyDown (KeyCode.V);
	}

	bool Interact(){
		return Input.GetKeyDown(KeyCode.F);
	}
}