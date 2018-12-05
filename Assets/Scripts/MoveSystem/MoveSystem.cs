using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class MoveSystem : ComponentSystem {

	public struct Data {
		public readonly int Length;
		public ComponentDataArray<HeadingComponent> heading;
		public ComponentDataArray<MoveSpeedComponent> speed;
		public ComponentArray<Rigidbody> rigidbody;		// Try to exclude this
	}

	[Inject] Data moveData;

    protected override void OnUpdate() {
       	for (int i = 0; i < moveData.Length; i++) {
			if(moveData.heading[i].value != Vector3.zero) {
				moveData.rigidbody[i].AddForce(moveData.heading[i].value * moveData.speed[i].value, ForceMode.Impulse);
				moveData.rigidbody[i].MoveRotation(Quaternion.LookRotation(moveData.heading[i].value));
			}
		}
    }
}
