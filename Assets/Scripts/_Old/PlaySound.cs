using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlaySound : MonoBehaviour {

	public Clip[] audioClips;

	public void Play (string sound) {
		for (int i = 0; i < audioClips.Length; i++) {
			if (audioClips[i] == null) {
				continue;
			}

			if (audioClips[i].name == sound) {
				AudioSource.PlayClipAtPoint (audioClips[i].audioContainer.GetAudioClip (), transform.position);
			}

		}
	}
}

[System.Serializable]
public class Clip {
	public string name;
	public AudioClipContainer audioContainer;
}