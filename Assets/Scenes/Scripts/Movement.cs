using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector3(0, 0, 0.1f));
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(0, 0, -0.1f));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(0.1f, 0, 0.1f));
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(-0.1f, 0, 0.1f));
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 500, 0));
        }
    }
}
