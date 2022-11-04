using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody rb;
    private void OnCollisionEnter(Collision collision)
    {
        Jump();
    }     
    private void Jump()
    {
        rb.velocity = new Vector3(0, (float)3.3, 0);
    }
}
