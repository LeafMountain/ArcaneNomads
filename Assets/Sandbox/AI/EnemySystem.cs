using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySystem : ComponentSystem<EnemyComponent> {

	protected override void OnUpdate(){
		UpdateComponentsList();
		
		Vector3 destination = transform.position + new Vector3(1, 0, 1) * 10;

		for (int i = 0; i < components.Length; i++)
		{
			if(components[i].agent == null){
				components[i].agent = components[i].GetComponent<NavMeshAgent>();
			}

			components[i].agent.SetDestination(destination);
		}
	}
}
