using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasController : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartGame(){
		SceneManager.LoadScene ("CenaTeste");
	}

	public void ReloadScene(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

	public void ExitScene(){
		SceneManager.LoadScene ("menu");
	}

	public void ExitGame(){
		Application.Quit ();
	}

	public void NextScene(){
		//chamar proxima cena
	}


}
