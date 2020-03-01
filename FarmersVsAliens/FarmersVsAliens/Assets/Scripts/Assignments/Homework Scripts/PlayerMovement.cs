using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public float initialVelocity = 0.0f;
    public float finalVelocity = 500.0f;
    public float currentVelocity = 0f;
    public float accelerationRate = 1000f;
    public float descelerationRate = 1f;

    Vector3 velocity;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -1f;
            currentVelocity = 0f;
        }


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * (z + currentVelocity); // Using a vector3 xyz will only move it on the world axis. Using this method keeps in mind where the player is facing and moves them accordingly.

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetKeyDown("space") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            currentVelocity = currentVelocity + (accelerationRate * Time.deltaTime);
            transform.Translate(0, 0, currentVelocity);
        }

        else
        {
            currentVelocity = currentVelocity - (descelerationRate * Time.deltaTime);
            if(currentVelocity > 0)
            {
                transform.Translate(0, 0, currentVelocity);
                
            }
            else
            {
                transform.Translate(0, 0, 0);
            }
        }

        currentVelocity = Mathf.Clamp01(currentVelocity * initialVelocity * finalVelocity);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
