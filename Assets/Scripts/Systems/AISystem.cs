using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class AISystem : ComponentSystem
{
	public struct Data 
	{
		public AIComponent AI;
		public Rigidbody Rigidbody;
	}

    protected override void OnUpdate()
    {
        foreach (var entity in GetEntities<Data>())
		{
			RotateTowardsVelocity(entity);
		}
    }

	void DoBehaviors (Data entity) {
		Vector3 force = Vector3.zero;

		for (int i = 0; i < entity.AI.template.behaviors.Length; i++) {
			if (entity.AI.template.behaviors[i]) {
				force += entity.AI.template.behaviors[i].DoBehavior (entity.AI);
			}
		}

		Seek (entity, force + entity.Rigidbody.position);
	}

	void Seek (Data entity, Vector3 target) {
		// The desired direction
		Vector3 desired;
		// Amount of force to apply
		Vector3 steer;

		Vector3 futurePosition = entity.Rigidbody.position + entity.Rigidbody.velocity;

		desired = target - futurePosition;
		desired = desired.normalized;
		desired *= entity.AI.template.maxSpeed;

		// Find the force to apply 
		steer = desired - entity.Rigidbody.velocity;
		steer = steer.normalized * entity.AI.template.maxForce;
		steer.y = 0;

		// Add force to physics system
		entity.Rigidbody.AddForce (steer);
	}

	public Vector3 GetFuturePosition (Data entity) {
		return entity.Rigidbody.position + entity.Rigidbody.velocity;
	}

	void RotateTowardsVelocity (Data entity) {
		Vector3 velocity = entity.Rigidbody.velocity;
		velocity.y = 0;

		if (velocity != Vector3.zero) {
			Quaternion lookRot = Quaternion.LookRotation (velocity);
			entity.Rigidbody.MoveRotation(Quaternion.Lerp(entity.Rigidbody.rotation, lookRot, Time.deltaTime * 5));
		}
	}
}
