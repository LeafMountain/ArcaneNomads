//A bar is four beats
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMixer  {

	private MusicManager mm; 
	private DJ dj;

	private int state;

	private BarMixer(){}
	public BarMixer(DJ dj){

		this.mm = dj.MM;
		this.dj = dj;
	}
	public void ClipPlaner(PlayerState ps){

			if(mm.debug)Debug.Log("Composing Bar with State: " + state.ToString() );

		state = (int)ps;
		
		switch (state)
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
				if(mm.StateValues[state] > 0.75)PlayTrack(Track.runningLate);
				if(mm.StateValues[state] >= 1)PlayTrack(Track.boom);
				break;
			case 4:
				PlayTrack(Track.drumBeat);
				if(mm.StateValues[state] > 0.75)PlayTrack(Track.brush);
				break;

	}
	
}
private void PlayTrack(Track t)
	{
		
			if(dj.TrackCooldowns[(int)t] == 0 && dj.BarCount % 2 != 0)
			{
				
				if(mm.debug)Debug.Log("Playing track " + t.ToString());
				mm.AudioSources[(int)t].clip = dj.PickedVariations[(int)t].GetAudioClip();
				dj.TrackCooldowns[(int)t] = mm.SoundLibrary[(int)t].clipBarLength;
				
				if(mm.SoundLibrary[(int)t].barStart == 1)
				{
					mm.AudioSources[(int)t].Play();
				}
				else
				{
					mm.AudioSources[(int)t].PlayDelayed(
						(mm.SoundLibrary[(int)t].barStart * 3.0f) - 1.0f);
				}
			}
			else if(t == Track.boom ||t == Track.heartBeat){
				mm.AudioSources[(int)t].Play();
			}
	}
}
