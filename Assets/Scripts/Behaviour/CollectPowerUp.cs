using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectPowerUp : MonoBehaviour {

    public int lifeGrowth = 1;

    public GameObject player;
    PlayerController vida;

    private void Awake()
    {
        vida = player.GetComponent<PlayerController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("powerUp"))
        {
            vida.life += lifeGrowth;
			if (GameObject.Find ("AudioManager") != null) {
				GameObject.Find ("AudioManager").GetComponent<AudioManager> ().PlayTrack ("Lvlup");
			}
            Debug.Log(vida.life);
            Destroy(other.gameObject);
        }

		if (other.CompareTag("endGame"))
		{
			if (GameObject.Find ("AudioManager") != null) {
				GameObject.Find ("AudioManager").GetComponent<AudioManager> ().PlayTrack ("Win");
			}
			StartCoroutine (NextLevel ());
			Destroy(other.gameObject);
		}
    }

	IEnumerator NextLevel(){
		yield return new WaitForSeconds (2f);
		if (SceneManager.GetActiveScene ().name == "Level 1") {
			SceneManager.LoadScene ("Level 2");
		} else if (SceneManager.GetActiveScene ().name == "Level 2")  {
			SceneManager.LoadScene ("Level Final");
		}else if (SceneManager.GetActiveScene ().name == "Level Final")  {
			SceneManager.LoadScene ("menu");
		}

	}
}
