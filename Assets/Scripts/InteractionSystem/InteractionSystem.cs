﻿using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;
using Unity.Transforms;
using Unity.Jobs;
using Unity.Mathematics;

public class InteractionSystem : ComponentSystem
{
    // public struct InteractionJob : IJobProcessComponentData<InteractableComponent, Position>
    // {
	// 	public float3 interactorPosition;
	// 	public float interactionDistance;

    //     public void Execute(ref InteractableComponent data, ref Position position) {
	// 		// check if interactable is within the interaction distance from the interactor
	// 		if(math.distance(position.Value, interactorPosition) < interactionDistance) {
	// 			// 
				
	// 		}
    //     }
    // }

	// protected override JobHandle OnUpdate(JobHandle inputDeps) {
	// 	InteractionJob interactionJob = new InteractionJob {
	// 		interactorPosition = new float3(0, 0, 0),
	// 		interactionDistance = 1.0f
	// 	};

	// 	return new JobHandle();
	// }

	// start job

    struct InteractablesData {
		public readonly int Length;
		public ComponentDataArray<InteractableComponent> components;
		[ReadOnly]public ComponentDataArray<Position> positions;
		public EntityArray entities;
		public SubtractiveComponent<InteractFocusComponent> InteractFocusComponent;
		// Exclude entities with the component interact focus
	}

	struct InteractorsData {
		public readonly int Length;
		[ReadOnly] public ComponentDataArray<InteractorComponent> components;
		[ReadOnly] public ComponentDataArray<Position> positions;
		[ReadOnly] public ComponentDataArray<PlayerInputComponent> inputs;
	}

	struct InteractFocusData {
		public readonly int Length;
		public ComponentDataArray<InteractFocusComponent> components;
		public ComponentArray<MeshRenderer> renderers;	// temp
	}

	struct DestroyData {
		public readonly int Length;
		public EntityArray entities;
		public ComponentDataArray<InteractingComponent> interactingComponents;
		public ComponentDataArray<InteractionEventComponent_Destroy> destroyComponents;
	}

	[Inject] InteractablesData interactables;
	[Inject] InteractorsData interactors;
	[Inject] InteractFocusData focusData;
	[Inject] DestroyData destroyData;

    protected override void OnUpdate(){
		// Add destroy tag
		for (int i = 0; i < destroyData.Length; i++){
			PostUpdateCommands.AddComponent(destroyData.entities[i], new DestroyComponent());
		}

		// Loop through the interactors
		for(int i = 0; i < interactors.Length; i++) {
			float interactDistance = interactors.components[i].distance;
			Vector3 interactorPosition = interactors.positions[i].Value;

			// Loop through all the interactables
			for(int j = 0; j < interactables.Length; j++) {
				Vector3 interactablePosition = interactables.positions[j].Value;

				// Check if interactor looking at interactable
				if(Vector3.Distance(interactablePosition, interactorPosition) < interactDistance){
					// Add interact focus. Fix this when you have excluded the correct components
					// if(!interactables.positions[j].GetComponent<InteractFocusComponentWrapper>()){
						Debug.Log("Im close to a new interactable");
						PostUpdateCommands.AddComponent(interactables.entities[j], new InteractFocusComponent());
						PostUpdateCommands.RemoveComponent(interactables.entities[j], typeof(InteractableComponent));
						// interactables.transforms[j].gameObject.AddComponent<InteractFocusComponentWrapper>();
					// }
				}
			}

			// Focus
			for (int j = 0; j < focusData.Length; j++) {
				// Add focus grapic
				focusData.renderers[j].material.color = Color.red;	// temp

				// Interact
				if(interactors.inputs[i].interact == 1) {
					PostUpdateCommands.AddComponent(interactables.entities[i], new InteractingComponent());
					// focusData.renderers[j].material.color = Color.green;	// temp
					// GameObject.Destroy(focusData.renderers[j].transform.gameObject);	// temp
				}
			}
		}
    }
}

