using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class GravitySystem : ComponentSystem
{
    struct Data
    {
        public readonly int Length;
        public ComponentDataArray<Velocity> Velocities;
    }

    // add another so that grounded entities reset their y velocity

    [Inject] Data data;

    protected override void OnUpdate()
    {
        float gravity = 0.9f;

        for (int i = 0; i < data.Length; i++)
        {
            Velocity velocity = data.Velocities[i];
            velocity.Value.y -= gravity;
            data.Velocities[i] = velocity;
        }
        // throw new System.NotImplementedException();
    }

}
