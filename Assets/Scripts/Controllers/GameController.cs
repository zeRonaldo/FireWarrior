using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour { //Controlador que vai centralizar o acesso a todos principais elementos do Jogo
	
	public static GameController instance;   
	public PlayerController Player;

	void Awake()
	{
		//If we don't currently have a game control...
		if (instance == null)
			//...set this one to be it...
			instance = this;
		//...otherwise...
		else if(instance != this)
			//...destroy this one because it is a duplicate.
			Destroy (gameObject);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
