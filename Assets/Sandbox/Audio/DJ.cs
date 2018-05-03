using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class DJ {

	private MusicManager mm;
	private int[] trackCooldowns;
	private int barCount;
	private DJ(){}
	public  DJ(MusicManager mm)
	{
		if(mm.debug) Debug.Log("Constructing <DJ>.......");
		this.mm = mm;
		barCount = 0;
		trackCooldowns = new int[(int)Track.Length];
		if(mm.debug) Debug.Log("<DJ> Constructed!");
	}
	public void UpdateState()
	{
		barCount++;
		if(mm.debug) Debug.Log("DJ.UpdateState, Bar Count: " + barCount);
		
		
		ClipPlaner(mm.state);
		CooldownCounter();
		if(mm.debug)Debug.Log("DJ.UpdateState Done");
	}
	private void ClipPlaner(PlayerState ps)
	{
		if(mm.debug)Debug.Log("Composing Bar with State: " + ps.ToString() );

		switch ((int)ps)
		{
			case 0:
				PlayTrack(Track.ambient);
				break;
			case 1:
				PlayTrack(Track.venyl);
				break;
			case 2:
				PlayTrack(Track.heartBeat);
				break;
			case 3:
				PlayTrack(Track.bassTop);
			//  PlayTrack(Track.runningLate);
				PlayTrack(Track.boom);
				break;
			case 4:
				PlayTrack(Track.drumBeat);
				break;
			
		}
			
			
			
			
		
		if(mm.debug)Debug.Log("Bar Composed");
	}
	private void PlayTrack(Track t)
	{
			if(trackCooldowns[(int)t] == 0)
			{
				if(mm.debug)Debug.Log("Playing track " + t.ToString());
				mm.AudioSources[(int)t].clip = mm.SoundLibrary[(int)t].GetAudioClip();
				trackCooldowns[(int)t] = mm.SoundLibrary[(int)t].clipBarLength;
				//mm.AudioSources[(int)t].PlayDelayed((mm.SoundLibrary[(int)t].barStart * 3.0f) - 1.0f);
				mm.AudioSources[(int)t].Play();
			}
			
		

		
	}
	private PlayerState DetermineState(float[] values)
	{
		float highestValue = values.Max();
		int highestValueIndex = values.ToList().IndexOf(highestValue);
		
		if(highestValueIndex == 0){
			return PlayerState.campSite;
		}
		else if(highestValueIndex == 1){
			return PlayerState.exploring;
		}
		else if(highestValueIndex == 2){
			return PlayerState.tension;
		}
		else if(highestValueIndex == 3){
			return PlayerState.spotted;
		}
		else if(highestValueIndex == 4){
			return PlayerState.danger;
		}

		return PlayerState.campSite;

	}
	private void CooldownCounter()
	{
		for (int i = 0; i < trackCooldowns.Length ; i++)
		{
			if(trackCooldowns[i] > 0){ trackCooldowns[i] -= 1;}
		}
	}

}
