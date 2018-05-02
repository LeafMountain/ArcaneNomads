using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class AudioClipContainer : ScriptableObject{

	public Track trackType;
	public AudioClip[] clips;

	public AudioClip GetRandomStartClip(){

		return clips[Random.Range(0,clips.Length)];
	}

	
}
