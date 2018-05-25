using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using XInputDotNetPure;

public class PlayerInputSystem : ComponentSystem {

	public struct PlayerData {
		public PlayerInput Input;
	}

	protected override void OnUpdate () {
		float2 nullValue = new float2 (0, 0);

		// float2 playerOneMove = JoystickInput (PlayerIndex.One);

		foreach (var entity in GetEntities<PlayerData> ()) {
			// entity.Input.Move.x = GamePad.GetState (entity.Input.playerIndex).ThumbSticks.Left.X;
			// entity.Input.Move.y = GamePad.GetState (entity.Input.playerIndex).ThumbSticks.Left.Y;

			entity.Input.Move.x = Input.GetAxis ("Horizontal");
			entity.Input.Move.y = Input.GetAxis ("Vertical");

			// bool2 checkIfNull = entity.Input.Move != nullValue;

			// if (checkIfNull.x && checkIfNull.y) {
			entity.Input.Move = math.normalize (entity.Input.Move);
			// }

			// entity.Input.OnMove.Invoke (new Vector2 (entity.Input.Move.x, entity.Input.Move.y));
		}
	}

	float2 JoystickInput (PlayerIndex index) {
		float2 input;

		input.x = GamePad.GetState (index).ThumbSticks.Left.X;
		input.y = GamePad.GetState (index).ThumbSticks.Left.Y;

		return input;
	}
}