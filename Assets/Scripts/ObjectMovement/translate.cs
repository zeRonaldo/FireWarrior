using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translate : MonoBehaviour {

	public float maxDist = 3.0f;
	public float velocity = 0.3f;
	private float originalPos;
	private float currentPos;
	private bool indo = true;

	void Start(){
		originalPos = this.transform.position.x;

	}

	void LateUpdate(){
		currentPos = this.transform.position.x;
		if(indo && (currentPos < (originalPos + maxDist))){
			this.transform.SetPositionAndRotation(new Vector3 (currentPos + velocity, this.transform.position.y,0 ), Quaternion.identity);
		}else if( indo && (currentPos >= (originalPos + maxDist))){
			indo = false;
			this.transform.SetPositionAndRotation(new Vector3 (currentPos - velocity, this.transform.position.y,0 ), Quaternion.identity);
		}else if( !indo && (currentPos > originalPos)){
			this.transform.SetPositionAndRotation(new Vector3 (currentPos - velocity, this.transform.position.y,0 ), Quaternion.identity);
		}else if(!indo && (currentPos <= originalPos)){
			indo = true;
			this.transform.SetPositionAndRotation(new Vector3 (currentPos - velocity, this.transform.position.y,0 ), Quaternion.identity);
		}
	}
}
