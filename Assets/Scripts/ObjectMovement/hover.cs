using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hover : MonoBehaviour {

	public float maxHeight = 3.0f;
	public float velocity = 0.3f;
	private float originalHeight;
	private float currentHeight;
	private bool subindo = true;
	private Rigidbody obj;

	void Start(){
		originalHeight = transform.position.y;

	}

	void LateUpdate(){
		currentHeight = transform.position.y;
		if(subindo && (currentHeight < (originalHeight + maxHeight))){
			transform.SetPositionAndRotation(new Vector3 (this.transform.position.x, currentHeight + velocity, 0), Quaternion.identity);
		}else if( subindo && (currentHeight >= (originalHeight + maxHeight))){
			subindo = false;
			transform.SetPositionAndRotation(new Vector3 (this.transform.position.x, currentHeight - velocity, 0), Quaternion.identity);
		}else if( !subindo && (currentHeight > originalHeight)){
			transform.SetPositionAndRotation(new Vector3 (this.transform.position.x, currentHeight - velocity, 0), Quaternion.identity);
		}else if(!subindo && (currentHeight <= originalHeight)){
			subindo = true;
			transform.SetPositionAndRotation(new Vector3 (this.transform.position.x, currentHeight - velocity, 0), Quaternion.identity);
		}
	}
}
