using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SuperCharacterController : MonoBehaviour {

	
	public enum RelativeDirection { Camera, World, Self }
	public enum RotationMode { MoveDirection, Manual }

	public RelativeDirection relativeTo;
	public RotationMode rotationMode;

	public float normalSpeed = 1f;
	public float speedMultiplier = .5f;
	public float smoothAmount;
	
	float Speed { get { return normalSpeed * speedMultiplier; }}

	Rigidbody rb;

	// Vector3 velocity;
	public Vector3 Velocity { 
		get{
			return rb.velocity;
		} 
	}

	public Vector3 ForwardVelocity { 
		get{
			return transform.InverseTransformDirection(rb.velocity);
		} 
	}

	Vector3 lastPosition = Vector3.zero;

	Vector3 currentVelocity;
	Vector3 velocity;
	[Range(0, 1)]

	[HideInInspector]
	public float currentSpeedPercentage;	//Make this into a property

	Vector3 moveDirection;

	// [SerializeField]
	// public UnityFloatEvent OnVelocity;

	Vector3 lookVelocity;
	public float lookSmooth;

	void Start(){
		rb = GetComponent<Rigidbody>();
	}

	void Update(){
		Vector3 newDir = lookDirection;
		// newDir = Vector3.SmoothDamp(transform.rotation.eulerAngles, lookDirection, ref lookVelocity, lookSmooth);

		if(newDir != Vector3.zero){
			transform.LookAt(transform.position + newDir);
		}

		// RotateToMoveDirection();
	}

	void FixedUpdate(){
		Vector3 newPos = transform.position;
		newPos = Vector3.SmoothDamp(transform.position, transform.position + moveDirection * Speed, ref currentVelocity, smoothAmount);
		
		// rb.MovePosition(newPos);
		// rb.AddForce(moveDirection * Speed, ForceMode.VelocityChange);
		rb.velocity = moveDirection * Speed;
	}

#region Move
	public void Move(Vector2 input){
		Vector3 _input = new Vector3(input.x, 0, input.y);
		Vector3 moveDirection = Vector3.zero;

		switch (relativeTo) {
			case(RelativeDirection.Camera):
				moveDirection = ConvertToCameraForward(_input);
				break;
			case(RelativeDirection.World):
				moveDirection = _input;
				break;
			case(RelativeDirection.Self):
				moveDirection = ConvertToSelfForward(_input);
				break;
			default:
				break;
		}

		this.moveDirection = moveDirection;
	}

	public void SetSpeed(float value){
		normalSpeed = value;
	}

#endregion

#region Rotation

	Vector3 lookDirection;

	public bool add;

	public void Rotate(Vector2 input){
		if(input == Vector2.zero){
			return;
		}

		Vector3 _input = new Vector3(input.x, 0, input.y);

		switch (relativeTo) {
			case(RelativeDirection.World):
				lookDirection = _input;
				break;
			case(RelativeDirection.Camera):
				lookDirection = ConvertToCameraForward(_input);
				break;
			case(RelativeDirection.Self):
				lookDirection = ConvertToSelfForward(_input);
				break;
		}

		// lookDirection += transform.position;
	}

	public void SetRotation(float pitch, float yaw, float roll){
		SetRotation(Quaternion.Euler(pitch, yaw, roll));
	}

	public void SetRotation(Quaternion rotation){
		Quaternion newRotation = rotation;
		transform.rotation = newRotation;
	}

	// void RotateToMoveDirection(){
	// 	Vector3 cameraForward = ConvertToCameraForward(moveDirection);
	// 	Vector2 direction = new Vector2(-cameraForward.z, cameraForward.x);
	// 	Rotate(direction);
	// }

#endregion

	//Common ------------------

	Vector3 ConvertToCameraForward(Vector3 position){
		Transform cameraTransform = Camera.main.transform;
		
		Vector3 cameraForward = cameraTransform.forward;
		cameraForward.y = 0;
		Vector3 cameraRight = cameraTransform.right;
		cameraRight.y = 0;
		Vector3 cameraUp = cameraTransform.up;
		cameraUp.y = 0;

		return ((cameraForward + cameraUp) * position.z + cameraRight * position.x).normalized;
	}

	Vector3 ConvertToSelfForward(Vector3 position){
		return transform.forward * position.z + transform.right * position.x;
	}
	
}
