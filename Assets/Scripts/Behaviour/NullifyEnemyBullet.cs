using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullifyEnemyBullet : MonoBehaviour {

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("EnemyBullet"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
