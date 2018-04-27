using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManagerSetup  {
	private MusicManager mm;
	private MusicManagerSetup(){}
	public MusicManagerSetup(MusicManager mm){
		this.mm = mm;
		SetUp();
	}
	private void SetUp()
	{
		if(mm.debug)Debug.Log("RUNNING RUNNING <MusicManagerSetup> RUNNING RUNNING");

			mm.StateValues = new float[(int)PlayerState.Length];
			mm.AudioSources = new AudioSource[(int)Track.Length];
			mm.UpdateInterval = 3.0f;
			LoadAudioClips();
			GetAudioSources();
			mm.DJRef = new DJ(mm);

		if(mm.debug)Debug.Log("COMPLETE COMPLETE <MusicManagerSetup> COMPLETE COMPLETE");
	}
	private void LoadAudioClips()
	{
		mm.SoundLibrary = new Dictionary<Track, List<AudioClip>>();
	}	
	private void GetAudioSources()
	{
		for (int i = 0; i < (int)Track.Length; i++)
		{
			mm.AudioSources[i] = mm.gameObject.AddComponent<AudioSource>();
			mm.AudioSources[i].loop = false;
		}
	}
	
}
