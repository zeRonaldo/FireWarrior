using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour {

	public Transform target;
	private Vector3 offset;

    private void Start()
    {
        offset = transform.position - target.transform.position;
    }

    void LateUpdate () {

        if (target != null)
        {
            transform.position = target.transform.position + offset;
            
        }
	}
}
