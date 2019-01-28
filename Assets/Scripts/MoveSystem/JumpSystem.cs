using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class JumpSystem : ComponentSystem
{
    struct Data
    {
        public readonly int Length;
        public ComponentDataArray<JumpComponent> Jumpers;
        public ComponentArray<Rigidbody> Rigidbodies; 
        public ComponentDataArray<PlayerInputComponent> Inputs;
    }

    [Inject] Data JumpData;

    protected override void OnUpdate()
    {
        for(int i = 0; i < JumpData.Length; i++)
        {
            if(JumpData.Inputs[i].jump == 1)
            {
                JumpData.Rigidbodies[i].AddForce(Vector3.up * JumpData.Jumpers[i].Force, ForceMode.Impulse);
            }
        }
    }
}
