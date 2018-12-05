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
		[ReadOnly]public ComponentArray<Transform> transforms;
		// Exclude entities with the component interact focus
	}

	struct InteractorsData {
		public readonly int Length;
		[ReadOnly] public ComponentDataArray<InteractorComponent> components;
		[ReadOnly] public ComponentArray<Transform> transforms;
		[ReadOnly] public ComponentArray<PlayerInputComponent> inputs;
	}

	struct InteractFocusData {
		public readonly int Length;
		public ComponentDataArray<InteractFocusComponent> components;
		public ComponentArray<MeshRenderer> renderers;	// temp
	}

	[Inject] InteractablesData interactables;
	[Inject] InteractorsData interactors;
	[Inject] InteractFocusData focusData;

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
					// Add interact focus. Fix this when you have excluded the correct components
					if(!interactables.transforms[j].GetComponent<InteractFocusComponentWrapper>()){
						Debug.Log("Im close to a new interactable");
						interactables.transforms[j].gameObject.AddComponent<InteractFocusComponentWrapper>();
					}
				}
			}

			// Focus
			for (int j = 0; j < focusData.Length; j++)
			{
				// Add focus grapic
				focusData.renderers[j].material.color = Color.red;	// temp

				// Interact
				if(interactors.inputs[i].interact) {
					focusData.renderers[j].material.color = Color.green;	// temp
				}
			}
		}

    }

	void Interact(int interactableIndex) {
		InteractableComponent interactable = interactables.components[interactableIndex];

		interactable.test = 1.0f;
		// Assign new interactable values to interactable
		interactables.components[interactableIndex] = interactable;
	}
}

