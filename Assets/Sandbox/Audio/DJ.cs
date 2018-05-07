using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class DJ {

	private MusicManager mm;
	private int[] trackCooldowns;
	private int barCount;
	private AudioClipContainer[] pickedVariations;
	private int currentState = 0;
	private BarMixer barMixer;
	private DJ(){}
	public  DJ(MusicManager mm)
	{
		if(mm.debug) Debug.Log("Constructing <DJ>.......");
		this.mm = mm;
		barCount = 0;
		trackCooldowns = new int[(int)Track.Length];
		pickedVariations = new AudioClipContainer[(int)Track.Length];
		barMixer = new BarMixer(this);
		PickTrackVariation();
		if(mm.debug) Debug.Log("<DJ> Constructed!");
	}
	public void UpdateState()
	{
		barCount++;

		mm.StateValues[(int)mm.state] = mm.stateValue;

		if(barCount==9) {barCount = 1;}
		if(mm.debug) Debug.Log("DJ.UpdateState, Bar Count: " + barCount);
		
		
		barMixer.ClipPlaner(mm.state);
		CooldownCounter();
		if(mm.debug)Debug.Log("DJ.UpdateState Done");
	}

	
	private void CooldownCounter()
	{
		for (int i = 0; i < trackCooldowns.Length ; i++)
		{
			if(trackCooldowns[i] > 0){ trackCooldowns[i] -= 1;}
		}
	}
	private void PickTrackVariation()
	{
		if(mm.debug)Debug.Log("DJ.PickTrackVariation");
		for (int i = 0; i < (int)Track.Length; i++)
		{
			pickedVariations[i] = mm.SortedACContainers[i][Random.Range(
											0, mm.SortedACContainers[i].Length)];
		}
	}
	//properties
	public int[] TrackCooldowns{get{return trackCooldowns;} set{trackCooldowns = value;}}
	public int BarCount{get{return barCount;}set{barCount = value;}}
	public int CurrentState{get{return currentState;}set{currentState = value;}}
	public MusicManager MM {get{return mm;}}
	public AudioClipContainer[] PickedVariations{get{return pickedVariations;}set{pickedVariations = value;}}
}
