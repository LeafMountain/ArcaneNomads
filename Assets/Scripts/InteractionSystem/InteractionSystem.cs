using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

[UpdateAfter(typeof(PlayerInputSystem))]
public class InteractionSystem : ComponentSystem
{
    struct InteractableData
    {
        public readonly int Length;
        [ReadOnly] public ComponentDataArray<InteractableFocus> Interactables;
        public ComponentArray<MeshRenderer> Renderers;
        SubtractiveComponent<Interacting> Interactings;
		public EntityArray Entities;
    }

    struct InteractorData
    {
        public readonly int Length;
        [ReadOnly] public ComponentDataArray<Interactor> Interactors;
        [ReadOnly] public ComponentDataArray<PlayerInputComponent> Inputs;
		public EntityArray Entities;
    }

    [Inject] InteractableData Interactables;
    [Inject] InteractorData Interactors;

    protected override void OnUpdate()
    {
        for(int i = 0; i < Interactors.Length; i ++)
        {
            for (int j = 0; j < Interactables.Length; j++)
            {
                if(Interactors.Inputs[i].interact == 1)
                {
                    Interacting interactingComponent;
                    interactingComponent.interactor = Interactors.Entities[i];
                    PostUpdateCommands.AddComponent<Interacting>(Interactables.Entities[j], interactingComponent);
                    Interactables.Renderers[j].material.color = Color.red;
                }
            }
        }
    }
}
