using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIWander : IAIState {

	public AIController Controller { get; set; }
	float range = 10;

	public void Enter(){
		Controller.agent.SetDestination(FindNewDestination());
	}

	public void Exit(){

	}

	public void Update(){
		if(Controller.agent.remainingDistance < Controller.agent.stoppingDistance){			
			Controller.agent.SetDestination(FindNewDestination());
		}
	}

	Vector3 FindNewDestination(){
		return Controller.transform.position + new Vector3(Random.Range(-range, range), 0, Random.Range(-range, range));
	}
}
