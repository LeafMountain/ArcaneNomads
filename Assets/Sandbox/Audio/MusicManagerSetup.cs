﻿using System.Collections;
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
		
		
			mm.DJRef = new DJ(mm);

		if(mm.debug)Debug.Log("COMPLETE COMPLETE <MusicManagerSetup> COMPLETE COMPLETE");
	}
	
	
	
}