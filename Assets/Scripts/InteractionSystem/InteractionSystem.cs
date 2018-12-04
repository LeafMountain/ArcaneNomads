using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

public class InteractionSystem : ComponentSystem
{
	struct InteractablesData {
		public readonly int Length;
		public ComponentDataArray<InteractableComponent> components;
		public ComponentArray<Transform> transforms;
	}

	struct InteractorsData {
		public readonly int Length;
		public ComponentDataArray<InteractorComponent> components;
		public ComponentArray<Transform> transforms;
		public ComponentArray<PlayerInputComponent> inputs;
	}

	[Inject] InteractablesData interactables;
	[Inject] InteractorsData interactors;

    protected override void OnUpdate(){
		// Loop through the interactors
		for(int i = 0; i < interactors.Length; i++) {
			float interactDistance = interactors.components[i].distance;
			Vector3 interactorPosition = interactors.transforms[i].position;

			// Loop through all the interactables
			for(int j = 0; j < interactables.Length; j++) {
				Vector3 interactablePosition = interactables.transforms[j].position;

				// Check if interactor looking at interactable
				if(Vector3.Distance(interactablePosition, interactorPosition) < interactDistance){
					Debug.Log("Im close to an interactable");

					// Interact
					if(interactors.inputs[i].interact){
						Interact(j);
						// InteractableComponent interactable;
						// interactable.interacted = true;

						// // Assign new interactable values to interactable
						// interactables.components[j] = interactable;

						Debug.Log(interactors.transforms[i].name + " is interacting with " + interactables.transforms[j].name);
					}
				}

			}
		}
    }

	void Interact(int interactableIndex) {
		InteractableComponent interactable = interactables.components[interactableIndex];
		// interactable.interacted = true;

		interactable.test = 1.0f;
		// // Assign new interactable values to interactable
		interactables.components[interactableIndex] = interactable;

		// interactables.components[interactableIndex].interacted = true;

		// Debug.Log(interactors.transforms[i].name + " is interacting with " + interactables.transforms[j].name);
	}
}

