using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

public class CharacterAnimationSystem : ComponentSystem
{
    struct Characters
    {
        public readonly int Length;
        public ComponentDataArray<Velocity> Velocities;
        public ComponentDataArray<MoveSpeed> MoveSpeeds;

        public ComponentArray<Animator> Animators;
    }

    [Inject] Characters characters;

    protected override void OnUpdate()
    {
        for (int i = 0; i < characters.Length; i++)
        {
            float3 velocity = characters.Velocities[i].Value;
            characters.Animators[i].SetFloat("VelocityX", velocity.x);
            characters.Animators[i].SetFloat("VelocityY", velocity.z);
        }
    }
}
