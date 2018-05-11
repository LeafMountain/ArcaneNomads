using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioButtonDebug : MonoBehaviour {

	public MusicManager mm;

	
	public void CampSite(){
		mm.state = PlayerState.campSite;
	}
	public void Exploring(){
		mm.state = PlayerState.exploring;
	}
	public void Tension(){
		mm.state = PlayerState.tension;
	}
	public void Spotted(){
		mm.state = PlayerState.spotted;
	}
	public void Dagner(){
		mm.state = PlayerState.danger;
	}



}
