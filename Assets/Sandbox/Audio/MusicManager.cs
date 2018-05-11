//This Class is the component used in Unity3D. This is the class that other components call.
//Every thing is working around a updatecycle of 0.75 of a second or one beat at 80 bpm.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Track { ambient, bassTop, runningLate, heartBeat, venyl, boom, 
drumBeat, newDay, brush, weather, Length }
public enum PlayerState{campSite, exploring, tension, spotted, danger, Length}

public class MusicManager : MonoBehaviour {

	//public properties
	public bool debug;
	public PlayerState state;
	
	public AudioClipContainer[] soundLibrary;
	//private properties
	private float updateInterval;
	private AudioClipContainer[][] sortedacContainers;
	private DJ djRef;	
	private bool gameRunning;
	private AudioSource[] audioSources;
	private float[] stateValues;
	private FadeTrack fadeTrack;
    

	void Start () {
		
		gameRunning = true;

		new MusicManagerSetup(this);
		fadeTrack = GetComponent<FadeTrack>();
	
		StartCoroutine(UpdateMusic());

	


	
		if(debug)Debug.Log("<MusicManager> up and running.....................");
	}
	
	
	
	public void Input(PlayerState ps, float value)
	{
		stateValues[(int)ps] += value;
	}
	
	IEnumerator UpdateMusic(){
		
		while(gameRunning)
		{
			yield return new WaitForSeconds(updateInterval);
			DJRef.UpdateState();
		}
	} 


	//properties
	public AudioSource[] AudioSources{get{return audioSources;}set{audioSources = value;}}
	public float UpdateInterval{get{return updateInterval;} set{updateInterval = value;} }
	public AudioClipContainer[] SoundLibrary{get{return soundLibrary;} 
		set{soundLibrary = value;}}
	public DJ DJRef {get{return djRef;} set{djRef = value;}}
	public AudioClipContainer[][] SortedACContainers {get{return sortedacContainers;}
		set{sortedacContainers = value;}}
	public FadeTrack _FadeTrack{get{return fadeTrack;}}


	
	
}
