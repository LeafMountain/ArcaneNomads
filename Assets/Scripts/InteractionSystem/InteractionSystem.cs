using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

public class InteractionSystem : ComponentSystem
{
    struct InteractableData
    {
        public readonly int Length;
        public ComponentDataArray<Interactable> Interactables;
        public ComponentDataArray<Position> Positions;
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
                if(Distance <= Reach)
                {

                }
                // Calculate view angle with the dot product
                // Check input?

            }
        }
    }
}
