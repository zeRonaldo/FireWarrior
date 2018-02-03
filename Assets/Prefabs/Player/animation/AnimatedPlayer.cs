using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedPlayer : MonoBehaviour {
	public GameObject player;

	//private AudioManager audio;
	Animator anim;
	int lifeCounter;

	// Use this for initialization
	void Start () {
		lifeCounter = player.GetComponent<PlayerController> ().life;
		anim = GetComponent<Animator>();
		//audio = GameObject.Find("AudioManager").GetComponent<AudioManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		Animate ();

	}

	void Animate () {
		

		/*if (playerRb.velocity.x == 0) {
			anim.SetTrigger ("Iddle");
		}else{
			anim.SetFloat ("speed", playerRb.velocity.x);
			Debug.Log("Andando");
		}*/
		float move = Input.GetAxis ("Horizontal");
		lifeCounter = player.GetComponent<PlayerController> ().life;
		anim.SetInteger ("life", lifeCounter);

		if (move != 0) {
			Walk ();
		} else {
			StopWalk ();
		}
		if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) {
			Jump ();
		}



	}

	void OnTriggerEnter(Collision col){
		if (col.gameObject.tag == "EnemyBullet" || col.gameObject.tag == "Enemy") {
			Hit ();
		}
	}



	public void StopWalk(){
		anim.SetBool("Walk", false);
	}

	public void Walk(){
		anim.SetBool("Walk", true);
	}
	public void Jump(){

		anim.SetTrigger("Jump");

	}

	public void Die(){
		
		anim.SetTrigger("Die");

	}

	public void Hit(){
		anim.SetTrigger("Hit");
	}
}
