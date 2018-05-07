using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoodSystem : MonoBehaviour {

	public enum State { calm, neutral, uneasy, tension, danger }
	public State state = State.calm;
	public float stateDecayTime = 3;


	private static MoodSystem instance;
	public static MoodSystem Instance {
		get {
			return instance;
		}
	}

	public EventHandler<State> OnStateChange;

	private float stateDecayTimer;

	void Awake() {
		if(instance == null){
			instance = this;
		}
		else {
			Debug.LogWarning("Two Mood Systems may not exist at the same time.");
			Destroy(this);
		}
	}

	void Update() {
		UpdateState();
	}

	float stateTimer;
	float StateTimer {
		get {
			stateTimer -= Time.deltaTime;
			return stateTimer;
		}
		set {
			stateTimer = value;
		}
	}

	void UpdateState () {
		switch (state)
		{
			case State.uneasy:
				DecayState();
				break;
			case State.tension:
				DecayState();
				break;
			case State.danger:
				DecayState();
				break;
		}
	}

	void DecayState (float timeMultiplier = 1) {
		stateDecayTimer -= Time.deltaTime * timeMultiplier;	
		stateDecayTimer = Mathf.Clamp(stateDecayTimer, 0, 60);

		if(stateDecayTimer == 0) { 
			SetState(state - 1, true);
		}
	}

	public void SetState (State state, bool overrideState = false) {
		if((int)this.state > (int)state && !overrideState){
			Debug.Log("Higher state active"); 
			return;
		}

		this.state = state;
		stateDecayTimer = stateDecayTime;

		if(OnStateChange != null){
			OnStateChange.Invoke(this, state);
		}

		Debug.Log("Switching state to " + state);
	}
}
