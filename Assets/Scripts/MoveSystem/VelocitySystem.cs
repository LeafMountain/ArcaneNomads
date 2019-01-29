using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

public class VelocitySystem : ComponentSystem
{
    struct Data
    {
        public readonly int Length;
        public ComponentDataArray<Heading> Headings;
        public ComponentDataArray<MoveSpeed> Speeds;
        public ComponentDataArray<Velocity> Velocities;
        public ComponentDataArray<Grounded> Groundeds;
    }

    [Inject] Data Movers;

    protected override void OnUpdate()
    {
        for(int i = 0; i < Movers.Length; i++)
        {
            Velocity NewVelocity = Movers.Velocities[i];
            float3 Heading = Movers.Headings[i].Value;
            float Speed = Movers.Speeds[i].Value;

            NewVelocity.Value = Heading * Speed;

            Movers.Velocities[i] = NewVelocity;
        }
    }
}
