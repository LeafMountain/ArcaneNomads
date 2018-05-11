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

		
			mm.AudioSources = new AudioSource[(int)Track.Length];
			GetAudioSources();
			SortAudioContainers(mm.SoundLibrary);
			mm.UpdateInterval = 0.75f; // a 0.75 second is the length of one beat at 80 bpm.
		
		
			mm.DJRef = new DJ(mm);

		if(mm.debug)Debug.Log("COMPLETE COMPLETE <MusicManagerSetup> COMPLETE COMPLETE");
	}
	
	private void GetAudioSources()
	{
		for (int i = 0; i < (int)Track.Length; i++)
		{
			mm.AudioSources[i] = mm.gameObject.transform.GetChild(i).GetComponent<AudioSource>();
		}
	}
	private void SortAudioContainers(AudioClipContainer[] containers)
	{
		if(mm.debug)Debug.Log("MusicManagerSetup.SortAudioContainers");
	
		mm.SortedACContainers = new AudioClipContainer[(int)Track.Length][];
		int[] trackVariationIndex = new int[(int)Track.Length];
		
		foreach (AudioClipContainer item in mm.SoundLibrary)
		{
			trackVariationIndex[(int)item.trackType]++;

			if(mm.debug)Debug.Log("TrackVariationIndex "  + item.trackType.ToString() + 
								" has value: " + trackVariationIndex[(int)item.trackType] );
		}

		
		for (int i = 0; i < mm.SortedACContainers.Length; i++)
		{
			mm.SortedACContainers[i] = new AudioClipContainer[trackVariationIndex[i]];	
		}

		for (int i = 0; i < (int)Track.Length; i++)
		{
			int index = 0;

			foreach (AudioClipContainer item in mm.SoundLibrary)
			{
				if((int)item.trackType == i)
				{
					mm.SortedACContainers[i][index] = item;
					index++;
				}
			}
		}
		if(mm.debug)Debug.Log("MusicManagerSetup.SortAudioContainers DONE");
	}
	
	
}
