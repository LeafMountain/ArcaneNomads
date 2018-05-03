using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class AudioClipContainer : ScriptableObject{

	public Track trackType;
	public AudioClip[] clip;
	public int clipBarLength;
	public int barStart;

	public AudioClip GetAudioClip(){
		return clip[Random.Range(0, clip.Length)];
	}
	
}
