using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {

    public GameObject tiro;
    public Transform gerarTiro;
    public float forcaTiro;
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;

    void Update()
    {

		if (Input.GetMouseButton (0)) {
			if (Time.time > nextFire) {
				nextFire = Time.time + fireRate;
				if (GameObject.Find ("AudioManager") != null) {
					GameObject.Find ("AudioManager").GetComponent<AudioManager> ().PlayTrack ("Shot");
				}
				//GameObject tiroTemp = Instantiate (tiro, gerarTiro.position, gerarTiro.rotation);
				GameObject tiroTemp = Instantiate(tiro, gerarTiro.position, gerarTiro.localRotation);
				tiroTemp.GetComponent<Rigidbody>() .AddForce (transform.right*forcaTiro);
				//tiroTemp.GetComponent<Rigidbody> ().AddForce (new Vector3 (forcaTiro, 0, 0));
			}
		}
    }



}
