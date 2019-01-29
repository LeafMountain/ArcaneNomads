using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

public class PlayerMoveSystem : ComponentSystem {
	public struct Data {
		public readonly int Length;
		public ComponentDataArray<PlayerInputComponent> inputs;
		public ComponentDataArray<Heading> headings;
	}

	[Inject] Data playerData;

	protected override void OnUpdate () {
		Camera camera = Camera.main;

		for (int i = 0; i < playerData.Length; i++) {
			Heading newComponent = playerData.headings[i];

			// Get input and convert to 3D
			Vector3 heading = new Vector3(playerData.inputs[i].Move.x, 0, playerData.inputs[i].Move.y);
			heading.Normalize();

			// Convert new heading to camera forward
			if(camera)
			{
				Vector3 headingToCameraForward = camera.transform.TransformDirection(heading);
				headingToCameraForward.y = 0;
				headingToCameraForward.Normalize();

				// Update heading value
				newComponent.Value = headingToCameraForward;
			}

			// Assign new heading
			playerData.headings[i] = newComponent;
		}
	}
}