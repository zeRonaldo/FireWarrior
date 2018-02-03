using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOnContact : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
			if (GameObject.Find ("AudioManager") != null) {
				GameObject.Find ("AudioManager").GetComponent<AudioManager> ().PlayTrack ("GameOver");
			}
			StartCoroutine (ReloadScene ());
			if (GameObject.Find ("PanelGameOver") != null) {
				GameObject.Find ("PanelGameOver").SetActive (true);
			}
        }
    }

	IEnumerator ReloadScene(){
		yield return new WaitForSeconds(3);
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}