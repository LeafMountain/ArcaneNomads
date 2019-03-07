using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class PickUpSystem : ComponentSystem
{
    struct Data
    {
        public readonly int Length;
        public ComponentDataArray<PickUp> PickUps;
        public ComponentDataArray<Interacting> Interactings;
        public EntityArray Entities;
    }

    [Inject] Data PickUpData;

    protected override void OnUpdate()
    {
        for (int i = 0; i < PickUpData.Length; i++)
        {
            Debug.Log("test");
            // PostUpdateCommands.AddComponent<Destroy>(PickUpData.Entities[i], new Destroy());
        }
    }
}
