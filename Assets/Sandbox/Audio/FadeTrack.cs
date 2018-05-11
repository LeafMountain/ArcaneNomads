using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Fader {wait, fadeIn, fadeOut}
public class FadeTrack : MonoBehaviour {

	

	public float fadeSpeed;

	public Fader switcher;

	public MusicManager mm;

	private List<AudioSource> sources;
	

	
	void Update () {

		if((int)switcher == 1 ){
			FadeIn();
		}
		if((int)switcher == 2){
			FadeOut();
		}
		
	}
	public void FadeIn()
	{
		foreach (AudioSource item in sources)
		{
			float currentVolume = item.volume;
			
			if(currentVolume < 1.0f) item.volume = currentVolume + (fadeSpeed * Time.deltaTime); 

			
				

			if(currentVolume >= 1) switcher = Fader.wait ; 
		}
	}
	public void FadeOut()
	{
		foreach (AudioSource item in sources)
			{
				float currentVolume = item.volume;
				
				if(currentVolume <= 1.0f)item.volume = currentVolume - (fadeSpeed * Time.deltaTime);
				if(currentVolume <= 0) switcher = Fader.wait; 
			}
	}
	public void StartFade(List<AudioSource> sources, Fader fadetype){
		this.sources = sources;
		switcher = fadetype;
	}
}
