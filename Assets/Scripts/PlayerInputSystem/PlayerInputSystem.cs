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
		public ComponentDataArray<PlayerInputComponent> Components;
	}

	[Inject] InputData inputData;

	protected override void OnUpdate ()
	{
		for (int i = 0; i < inputData.Length; i++){
			PlayerInputComponent newComponent = inputData.Components[i];

			Vector2 move = UnityMove ();
			Vector2 look = Look ();

			newComponent.Move = move;
			newComponent.Look = look;
			newComponent.swapShoulder = SwapShoulder ();
			newComponent.aim = Aim ();
			newComponent.sprint = Sprint ();
			newComponent.reload = Reload ();
			newComponent.fire = Fire ();
			newComponent.interact = Interact();
			newComponent.jump = Input.GetButton("Jump") ? 1 : 0;

			inputData.Components[i] = newComponent;
		}
	}

	Vector2 Move ()
	{
		Vector2 move = UnityMove ();
		return move;
	}

	Vector2 Look ()
	{
		Vector2 look = UnityLook ();
		return look;
	}

	int Fire ()
	{
		return Input.GetButton ("Fire") ? 1 : 0;
	}

	int Reload ()
	{
		return Input.GetKeyDown (KeyCode.R) ? 1 : 0;
	}

	int Sprint ()
	{
		return Input.GetKey (KeyCode.LeftShift) ? 1 : 0;
	}

	int Aim ()
	{
		return Input.GetButton ("Aim") ? 1 : 0;
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

	int SwapShoulder ()
	{
		return Input.GetKeyDown (KeyCode.V) ? 1 : 0;
	}

	int Interact(){
		return Input.GetKeyDown(KeyCode.F) ? 1 : 0;
	}
}