using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
	public Vector3 velocidade;
	
	void Update () {

		transform.Rotate(velocidade * Time.deltaTime);
	}
}
