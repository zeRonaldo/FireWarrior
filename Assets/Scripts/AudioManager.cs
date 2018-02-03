using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
	AudioSource source;
	public AudioClip[] Clips;
	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
		source.loop = true;
		source.clip = Clips [4];
		source.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayTrack(string track){
		switch (track) {
		case "Enemy":
			source.PlayOneShot (Clips[0]);
			break;
		case "GameOver":
			source.PlayOneShot (Clips[1]);
			break;
		case "Jump":
			source.PlayOneShot (Clips[2]);
			break;
		case "Lvlup":
			source.PlayOneShot (Clips[3]);
			break;
		case "Firewall":
			source.PlayOneShot (Clips[4]);
			break;
		case "Shot":
			source.PlayOneShot (Clips[5]);
			break;
		case "Win":
			source.PlayOneShot (Clips[6]);
			break;
		default:
			break;
		}
	}
}
