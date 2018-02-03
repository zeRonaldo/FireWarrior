using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class harderToPush : MonoBehaviour
{
    private Rigidbody thisRB;

    private float mass;

    private void Start()
    {
        thisRB = GetComponent<Rigidbody>();
        mass = thisRB.mass;
    }
    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("pushThisModarfucka"))
        {
            thisRB.mass *= 10;
        }
    }
    void OnCollisionExit(Collision other)
    {
            thisRB.mass = mass;
    }
}
