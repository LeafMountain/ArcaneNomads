using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

public class InteractionSystem : ComponentSystem
{
	struct Interactables {
		[ReadOnly]
		public ComponentDataArray<InteractableComponent> interactables;
	}

	struct Interactors {
		[ReadOnly]
		public ComponentDataArray<InteractorComponent> interactors;
	}

	[Inject] Interactables interactables;
	[Inject] Interactors interactors;

    protected override void OnUpdate(){
		for(int i = 0; i < interactors.interactors.Length; i++) {
			for(int j = 0; j < interactables.interactables.Length; j++) {
				// Check if interactor looking at interactable

				// Interact
			
			}
		}
    }
}
