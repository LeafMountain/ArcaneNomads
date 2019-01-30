using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
using Unity.Transforms;
using Unity.Collections;
using Unity.Mathematics;

public class RotationSystem : ComponentSystem
{
    public struct Data
    {
        public readonly int Length;
        [ReadOnly] public ComponentArray<Transform> Transforms;
        public ComponentDataArray<Heading> Headings;
    }

    [Inject] Data Entities;

    protected override void OnUpdate()
    {
        for(int i = 0; i < Entities.Length; i++)
        {
            if((Vector3)Entities.Headings[i].Value != Vector3.zero)
                Entities.Transforms[i].forward = Entities.Headings[i].Value;
        }
    }
}
