using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class CallScene : MonoBehaviour {
	float duration;
	// Use this for initialization
	void Start () {
		duration = (float)transform.GetComponent<PlayableDirector> ().duration;
		StartCoroutine (WaitAndCall ());
	}
	
	// Update is called once per frame
	void Update () {
//		if (GetComponent<PlayableDirector> ().time <= 0) {
//			SceneManager.LoadScene ("menu");
//		}
	}

	IEnumerator WaitAndCall(){
		yield return new WaitForSeconds (duration);
		SceneManager.LoadScene ("menu");
	}
}
