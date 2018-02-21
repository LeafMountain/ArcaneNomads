using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIController : MonoBehaviour {

	IAIState currentState;

	[HideInInspector]
	public NavMeshAgent agent;

	void Start(){
		agent = GetComponent<NavMeshAgent>();
		ChangeState(new AIWander());
	}

	public void ChangeState(IAIState newState){
		if(currentState != null){
			currentState.Exit();
		}
		currentState = newState;
		currentState.Controller = this;
		currentState.Enter();
		Debug.Log("Entered: " + currentState);
	}

	void Update () {
		currentState.Update();
	}
}
