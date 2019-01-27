using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
using Unity.Transforms;

public class RotationSystem : ComponentSystem
{
    public struct Data
    {
        public int Length;
        public ComponentDataArray<RotationSpeedComponent> Speeds;
        public ComponentDataArray<Rotation> Rotations;
    }

    protected override void OnUpdate()
    {
        
    }
}
