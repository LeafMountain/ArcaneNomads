using System.Collections;
using System.Collections.Generic;
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
        public ComponentDataArray<Interactable> Interactables;
        public ComponentDataArray<Position> Positions;
		public EntityArray Entities;
    }

    struct InteractorData
    {
        public readonly int Length;
        public ComponentDataArray<Interactor> Interactors;
        public ComponentDataArray<Position> Positions;
        public ComponentDataArray<PlayerInputComponent> Inputs;
    }

    [Inject] InteractableData Interactables;
    [Inject] InteractorData Interactors;

    protected override void OnUpdate()
    {
        for(int i = 0; i < Interactors.Length; i ++)
        {
            float3 InteractorPosition = Interactors.Positions[i].Value;
            bool Input = Interactors.Inputs[i].interact == 1;
            float Reach = Interactors.Interactors[i].Reach;
            float Angle = Interactors.Interactors[i].Angle;

            for(int j = 0; j < Interactables.Length; j ++)
            {
                float3 InteractablePosition = Interactables.Positions[j].Value;

                // Calculate distanc
                float Distance = math.distance(InteractorPosition, InteractablePosition);

                if(Input)
                {
                    Debug.Log(Distance);
                }

                if(Distance <= Reach)
                {
                    float DotProduct = math.dot(InteractorPosition, InteractablePosition);
                    // Calculate view angle with the dot product
                    if(DotProduct > 0)
                    {
                        // PostUpdateCommands.AddComponent<InteractableFocus>(Interactables.Entities[j], new InteractableFocus());
                        // Debug.Log("Dot = " + DotProduct);
                        // Check input?
                        if(Input)
                        {
                            PostUpdateCommands.AddComponent<DestroyComponent>(Interactables.Entities[j], new DestroyComponent());
                            Debug.Log("Interacting");
                        }
                    }
                }

            }
        }
    }
}
