﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tooFar : MonoBehaviour {
	public float ttl;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, ttl);
	}
	

}
