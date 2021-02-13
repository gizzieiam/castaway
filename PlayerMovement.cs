using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    void Update()
    {
        float xAxis = Input.GetAxisRaw("Horizontal");
        float zAxis = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector3(xAxis, rb.velocity.y, zAxis)*speed;

    }
}
