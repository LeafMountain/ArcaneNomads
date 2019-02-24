using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;

public class GroundedSystem : ComponentSystem
{
    struct NonGroundedData
    {
        public readonly int Length;
        public ComponentDataArray<Position> Positions;
        public ComponentDataArray<Velocity> Velocities;
        public SubtractiveComponent<Grounded> Groundeds;
		public EntityArray Entities;

    }

    struct GroundedData
    {
        public readonly int Length;
        public ComponentDataArray<Position> Positions;
        public ComponentDataArray<Velocity> Velocities;
        public ComponentDataArray<Grounded> Groundeds;
		public EntityArray Entities;
    }

    [Inject] NonGroundedData NotGrounded;
    [Inject] GroundedData IsGrounded;

    protected override void OnUpdate()
    {
        for(int i = 0; i < NotGrounded.Length; i ++)
        {
            float3 Position = NotGrounded.Positions[i].Value;
            RaycastHit Hit;

            if(Physics.SphereCast((Vector3)Position - Vector3.down * 0.1f, 0.15f, Vector3.down, out Hit, 0.1f))
            {
                Debug.DrawRay(Position, Vector3.down, Color.green);
                PostUpdateCommands.AddComponent<Grounded>(NotGrounded.Entities[i], new Grounded());
                // Debug.Log("grounded");
            }
        }

        for(int i = 0; i < IsGrounded.Length; i++)
        {
            float3 Position = IsGrounded.Positions[i].Value;
            RaycastHit Hit;

            if(!Physics.Raycast((Vector3)Position - Vector3.down * 0.1f, Vector3.down, out Hit, 0.1f))
            {
                Debug.DrawRay(Position, Vector3.down, Color.red);
                PostUpdateCommands.RemoveComponent<Grounded>(IsGrounded.Entities[i]);
                // Debug.Log("not grounded");                
            }
        }
    }
}
