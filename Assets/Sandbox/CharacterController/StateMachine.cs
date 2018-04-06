using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StateMachine : MonoBehaviour {

	public State[] states;

	State currentState;

	public void ChangeState(int index){
		if(index < 0 || index > states.Length){
			Debug.LogError("Index outside range.");
			return;
		}

		if(currentState != null){
			currentState.Exit();
		}

		currentState = states[index];
		currentState.Enter();
	}

	public void ChangeState(string name){
		for (int i = 0; i < states.Length; i++)
		{
			if(states[i].name == name){
				ChangeState(i);
				return;
			}
		}

		Debug.LogError("No state with the name of " + name + ".");
		return;
	}
	
}

[System.Serializable]
public class State {
	public string name;
	public UnityEvent OnEnter;
	public UnityEvent OnExit;

	public void Enter(){
		OnEnter.Invoke();
	}

	public void Exit(){
		OnExit.Invoke();
	}
}
