using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {
	int tipoPowerUp;
	// Use this for initialization

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Coletado(){
		switch (tipoPowerUp) {
		case 0:
			Destroy (this.gameObject);
			break;
		default:
			break;
		}
	}
}
