using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

[System.Serializable]
public struct MoveComponent : IComponentData
{
    public float speed;
    public float maxSpeed;
    public float3 heading;
}

public class MoveComponentWrapper : ComponentDataWrapper<MoveComponent> {}

// [RequireComponent(typeof(CharacterController))]
// public class MoveComponent : MonoBehaviour
// {
//     // In meters per sencond
//     [Range(0, 1000)]
//     public float Speed = 1;

//     public float MaxSpeed = 100;

//     [Range(0, 10)]
//     public float TurnSpeed = 5;

//     [Range(0, 1)]
//     public float MoveSmoothing;

//     public Vector3 Velocity;

//     private CharacterController CharacterController;
//     private Rigidbody Rigidbody;
//     private Vector3 TargetPosition = Vector3.zero;

//     void Awake() {
//         CharacterController = GetComponent<CharacterController>();
//         Rigidbody = GetComponent<Rigidbody>();

//         TargetPosition = transform.position;
//     }

//     void Update () {
//         Vector3 CurrentPosition = transform.position;
//         Vector3 TargetPosition = this.TargetPosition;
//         Vector3 SmoothMovePosition = Vector3.SmoothDamp(CurrentPosition, TargetPosition, ref Velocity, MoveSmoothing, MaxSpeed);
//         Vector3 MoveDirection = SmoothMovePosition - CurrentPosition;

//         CharacterController.Move(MoveDirection * Time.deltaTime);

//         if(MoveDirection != Vector3.zero)
//             transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(MoveDirection, Vector3.up), Time.deltaTime * TurnSpeed);
//     }

//     public void Move(Vector2 Direction) {
//         if(Direction != Vector2.zero) {
//             Vector3 Direction3D = new Vector3(Direction.x, 0, Direction.y);
//             TargetPosition = transform.position + Direction3D * Speed;
//         }
//     }

//     public bool Grounded() {
//         Ray DownRay = new Ray(transform.position, Vector3.down);
//         return Physics.Raycast(DownRay, 1f);
//     }
// }
