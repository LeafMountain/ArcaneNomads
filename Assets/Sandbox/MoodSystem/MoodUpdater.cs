using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoodUpdater : MonoBehaviour {

	MoodSystem moodSystem;

	public MoodSystem.State newMoodState;
	public bool overrideState;
	public bool updateMood;

	void Start () {
		moodSystem = MoodSystem.Instance;
	}

	void Update () {
		if(updateMood) {
			updateMood = false;
			moodSystem.SetState(newMoodState, overrideState) ;
		}
	}
}
