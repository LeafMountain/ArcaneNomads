//A bar is four beats
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMixer  {

	private MusicManager mm; 
	private DJ dj;
	private List<AudioSource> sourcesInUse;

	private int state;

	private BarMixer(){}
	public BarMixer(DJ dj){

		this.mm = dj.MM;
		this.dj = dj;
		sourcesInUse = new List<AudioSource>();
	}
	public void ClipPlaner(PlayerState ps){

			if(mm.debug)Debug.Log("Composing Bar with State: " + state.ToString() );

		
		if(state != (int)ps)
			{	mm._FadeTrack.StartFade(sourcesInUse, Fader.fadeOut);
											sourcesInUse.Clear();}
		
		switch (state)
		{
			case 0:
				PlayTrack(Track.ambient,ps);
				state = (int)ps;
				break;
			case 1:
				PlayTrack(Track.venyl,ps);
				state = (int)ps;
				break;
			case 2:
				PlayTrack(Track.heartBeat,ps);
				state = (int)ps;
				break;
			case 3:
				PlayTrack(Track.bassTop,ps);
				PlayTrack(Track.runningLate,ps);
				PlayTrack(Track.boom,ps);
				state = (int)ps;
				break;
			case 4:
				PlayTrack(Track.drumBeat,ps);
				PlayTrack(Track.brush,ps);
				
				state = (int)ps;
				break;

			

	}
	
}
private void PlayTrack(Track t, PlayerState ps)
	{
		if((int)ps != state){
			sourcesInUse.Add(mm.AudioSources[(int)t]);
		}

			if(dj.TrackCooldowns[(int)t] == 0)
			{
				
				if(mm.debug)Debug.Log("Playing track " + t.ToString());
				
				//ResetVolume
				mm.AudioSources[(int)t].volume = 1.0f;
				//Picking a random AudioClip from the PickedVariations.
				mm.AudioSources[(int)t].clip = dj.PickedVariations[(int)t].GetAudioClip();
				//Adding the cooldown for the track.
				dj.TrackCooldowns[(int)t] = mm.SoundLibrary[(int)t].clipBeatLength;
				
				if(mm.SoundLibrary[(int)t].beatStart == 1)
				{
					
					mm.AudioSources[(int)t].Play();
				}
				else
				{
					mm.AudioSources[(int)t].PlayDelayed(
						(mm.SoundLibrary[(int)t].beatStart * 3.0f) - 1.0f);
				}
			}
			
	}
}
