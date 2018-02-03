using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public int life = 5;
    public int power = 0;

    private bool isJumping;
	private bool isAlive=true;
  
    public float jumpDelay = 0.6f;

    private Rigidbody playerRB;

    public float Speed;


    //private bool isFalling = false;
    public float jumpHeight = 5;

    // Use this for initialization
    void Start()
    { 	
		
        playerRB = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
	{	if (isAlive) {
			Controler ();
		}
    }



	//CONTROLES
    void Controler()
    {

		float move = Input.GetAxis ("Horizontal");
		float jump = Input.GetAxis ("Vertical");
		if (move != 0) {
			Move (move);
		}

		if ((jump != 0) && (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) ){
			GetComponentInChildren<AnimatedPlayer> ().Jump ();
			Jump();
		}
			/*
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
			
            Move(-Speed);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {

            Move(Speed);
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {

            Jump();
        }*/
    }



    void Move(float vel)
    {	
		if (isJumping) {
			vel = vel * 0.6f;
		}
		if (vel > 0) {
			transform.eulerAngles = new Vector3(0, 0, 0); // Normal
					playerRB.AddForce(transform.right * (vel*Speed) , ForceMode.VelocityChange);
		}else{
			transform.eulerAngles = new Vector3(0, 180, 0); // Normal
					playerRB.AddForce(- transform.right * (vel*Speed) , ForceMode.VelocityChange);
		}
        //playerTrn.Translate(new Vector3(vel, 0, 0) * Time.deltaTime);
		//playerRB.AddForce(transform.right * vel , ForceMode.Acceleration);
    }

    void Jump()
	{	
        if (!isJumping)
		{
			if (GameObject.Find ("AudioManager") != null) {
				GameObject.Find ("AudioManager").GetComponent<AudioManager> ().PlayTrack ("Jump");
			}
            isJumping = true;
			playerRB.AddForce(transform.up*(jumpHeight*2), ForceMode.VelocityChange);
		

            Invoke("resetIsJumping", 1.5f);
        }
    }

    private void resetIsJumping()
    {
        isJumping = false;
    }



	//COLLISIONS AND TRIGGERS
    void onTriggerEnter(Collision col)
    {

        if (col.gameObject.tag.Contains("powerUp"))
        {
            if (life < 5)
            {
            Destroy(col.gameObject);
                life++;
                Debug.Log("up");
            }
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "EnemyBullet"||col.gameObject.tag == "Enemy")
        {
			if (GameObject.Find ("AudioManager") != null) {
				GameObject.Find ("AudioManager").GetComponent<AudioManager> ().PlayTrack ("Enemy");
			}
			if (life > 0) {
				//GetComponentInChildren<AnimatedPlayer> ().Hit ();
				life--;
				transform.Translate (-2, 2, 0);
				if (col.gameObject.tag == "EnemyBullet") {
					Destroy (col.gameObject);
				}  
			} else {
				isAlive = false;
				StartCoroutine (ReloadScene());
				//GetComponentInChildren<AnimatedPlayer> ().Hit ();
			}

            
        }
    }

	public IEnumerator ReloadScene(){
		yield return new WaitForSeconds(2);
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

}
