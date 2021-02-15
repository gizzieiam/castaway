using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static bool isActive;
    public static float speed;
    public float time;
    public bool isGrounded;
    public Vector3 jump;
    public int jumpCount;
    private Rigidbody self;
    public CharacterController controller;

    void Start()
    {
        self = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
        jumpCount = 0;
        time = 0.0f;
        speed = 5f;
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {

            float moveX = Input.GetAxis("Horizontal");
            float moveZ = Input.GetAxis("Vertical");

            Vector3 move = transform.right * moveX + transform.forward * moveZ;

            controller.Move(move*speed* Time.deltaTime);
            if(isGrounded)
            {
                transform.Translate(moveX * Time.deltaTime * speed, 0, moveZ * Time.deltaTime);
                if(Input.GetButtonDown("Jump"))
                {
                    jumpCount = jumpCount + 1;
                    self.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
                    isActive = true;
                }
                if(jumpCount == 2)
                {
                    isGrounded = false;
                    jumpCount = 0;                
                }
            }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}
