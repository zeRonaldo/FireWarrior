using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class TextTyper : MonoBehaviour {

	[Header("Tempo entre letras")]
	public float letterPause = 0.2f;
	private bool ended;
	[Header("Chama Level 1 ao final")]
	public bool CallScene1;
	[Header("Textos a serem exibidos em ordem")]
	[TextArea(3,10)]
	public string[] textos;
	private int textCounter;

	string message;
	Text textComp;

	// Use this for initialization
	void Start () {
		textCounter = 0;
		textComp = GetComponent<Text>();
		message = textos[textCounter];
		textComp.text = "";
		StartCoroutine(TypeText ());
	}

	void Update(){

		if (ended == true) {
			ended = false;
			if (textCounter < textos.Length - 1) {
				StartCoroutine (CallNextText ());
			} else {
				if (CallScene1) {
					StartCoroutine (CallNextScene ());
				}
			}
		}

	}

	IEnumerator CallNextScene () {
		yield return new WaitForSeconds (2);
		SceneManager.LoadScene ("Level 1");
	}

	IEnumerator CallNextText () {
		yield return new WaitForSeconds (2);
		textComp = GetComponent<Text>();
		message = textos[++textCounter];
		textComp.text = "";
		StartCoroutine(TypeText ());
	}

	IEnumerator TypeText () {
		foreach (char letter in message.ToCharArray()) {
			textComp.text += letter;
			yield return 0;
			yield return new WaitForSeconds (letterPause);
		}
		ended = true;
	}
}
