using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour {

    public Transform[] enemyPointPosition;
    public float speed;
    public float waitTime;

    private int randomic;
    private float time;

	void Start () {
        randomic = Random.Range(0, enemyPointPosition.Length);
        time = waitTime;
	}

    private void Update()
    {
		if (enemyPointPosition.Length > 0) {
			transform.position = Vector2.MoveTowards (transform.position, enemyPointPosition [randomic].position,
				speed * Time.deltaTime);
			float distance = Vector2.Distance (transform.position, enemyPointPosition [randomic].position);

			if (distance <= .2f) {
				if (time <= 0) {
					randomic = Random.Range (0, enemyPointPosition.Length);
					time = waitTime;
				} else
					time -= Time.deltaTime;
			}
		}
    }
}
