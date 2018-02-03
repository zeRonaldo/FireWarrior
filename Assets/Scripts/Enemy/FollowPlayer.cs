using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    float alcance;

    public float velocidadeObjeto = 2f;
    public float distanciaMin = 2f;

    private void Update()
    {
        if (player != null)
        {
            alcance = Vector3.Distance(transform.position, player.position);
            if (alcance <= distanciaMin)
            {
                transform.position = Vector3.MoveTowards(transform.position, player.position, velocidadeObjeto * Time.deltaTime);
            }
        }
    }
}