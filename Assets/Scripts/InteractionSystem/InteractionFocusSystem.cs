using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
using Unity.Transforms;
using Unity.Collections;
using Unity.Mathematics;

public class InteractionFocusSystem : ComponentSystem
{
    struct Interactables
    {
        public readonly int Length;
        [ReadOnly] public ComponentDataArray<Position> position;
        [ReadOnly] public ComponentDataArray<Interactable> interactable;
        [ReadOnly] public SubtractiveComponent<InteractableFocus> focus;
		public EntityArray Entities;
    }

    struct Interactors
    {
        public readonly int Length;
        [ReadOnly] public ComponentDataArray<Position> position;
        [ReadOnly] public ComponentDataArray<Interactor> interactor;
    }

    [Inject] Interactables interactables;
    [Inject] Interactors interactors;

    protected override void OnUpdate()
    {
        for(int i = 0; i < interactors.Length; i ++)
            for (int j = 0; j < interactables.Length; j++)
            {
                float distance = math.distance(interactors.position[i].Value, interactables.position[j].Value);
                if(distance < interactors.interactor[i].Reach)
                {
                    // I'm close enough to interact
                    PostUpdateCommands.AddComponent<InteractableFocus>(interactables.Entities[j], new InteractableFocus());
                }
            }
    }
}
