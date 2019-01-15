using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MoveComponent : MonoBehaviour
{
    // In meters per sencond
    [Range(0, 1000)]
    public float Speed = 1;

    public float MaxSpeed = 100;

    [Range(0, 10)]
    public float Acceleration;

    [Range(0, 1)]
    public float MoveSmoothing;

    public Vector3 Velocity;

    private CharacterController CharacterController;
    private Rigidbody Rigidbody;
    private Vector3 TargetPosition = Vector3.zero;

    void Awake() {
        CharacterController = GetComponent<CharacterController>();
        Rigidbody = GetComponent<Rigidbody>();

        TargetPosition = transform.position;
    }

    void Update () {
        Vector3 CurrentPosition = transform.position;

        // Vector3 TargetPosition = CurrentPosition + this.TargetPosition;
        Vector3 SmoothDirection = Vector3.SmoothDamp(CurrentPosition, TargetPosition, ref Velocity, MoveSmoothing, MaxSpeed);
        CharacterController.Move(SmoothDirection - CurrentPosition);
    }

    public void Move(Vector2 Direction) {

        if(Direction != Vector2.zero) {
            Vector3 Direction3D = new Vector3(Direction.x, 0, Direction.y);
            TargetPosition = transform.position + Direction3D * Speed;
        }
    }

    public bool Grounded() {
        Ray DownRay = new Ray(transform.position, Vector3.down);
        return Physics.Raycast(DownRay, 1f);
    }
}
