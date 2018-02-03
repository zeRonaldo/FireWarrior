using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour {

    public GameObject tiro;
    public Transform gerarTiro;
    public float forcaTiro;
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;

    void Update()
    {

        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GameObject tiroTemp = Instantiate(tiro, gerarTiro.position, gerarTiro.rotation);
            tiroTemp.GetComponent<Rigidbody>().AddForce(new Vector3(forcaTiro, 0, 0));
        }
    }

}
