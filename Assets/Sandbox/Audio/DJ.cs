﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DJ {

	private MusicManager mm;
	private DJ(){}
	public  DJ(MusicManager mm)
	{
		if(mm.debug) Debug.Log("Constructing <DJ>.......");
		this.mm = mm;

		if(mm.debug) Debug.Log("<DJ> Constructed!");
	}
	public void UpdateState()
	{
		if(mm.debug) Debug.Log("DJ.UpdateState");

		if(mm.debug)Debug.Log("DJ.UpdateState Done");

	}
	public void ComposeBar()
	{
		if(mm.debug)Debug.Log("Composing Bar");

		if(mm.debug)Debug.Log("Bar Composed");
	}

}