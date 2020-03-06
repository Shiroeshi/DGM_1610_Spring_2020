using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //Declaration
    public float speed;
    public float verticalInput;
    public float horizontalInput;
    public float turnSpeed;
    public float accelSpeed = 1000f;

    public float jumpHeight = 50f;
    public bool isGrounded;

    private Rigidbody rb;

    public GameObject projectilePrefab; 
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");  //GetAxis is keymapping. Input keeps track of the inputs within the argument. 
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput); //Using the f as the end identifies it as a float command so we dont have to make a variable to track it. 
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
                                // (x,y,z) Using the vector method optimizes it so we set it in unity instead. 

        if(Input.GetKeyDown(KeyCode.F)) //Getkeydown tracks a key only when it is fully pressed
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation); // Instantiate creates the object into the scene. The first point makes the object, while the second and third manipulate the object.
                      
        }  

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpHeight * 1000 * Time.deltaTime);
            
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Floor") || other.gameObject.CompareTag("Obstacle")) // Using this second portion, we can make it so that we can jump again off of a wall/osbtacle
        {
            isGrounded = true;
            Debug.Log("Touching floor");
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Floor") || other.gameObject.CompareTag("Obstacle"))
        {
            isGrounded = false;
            Debug.Log("Not touching floor");
            rb.AddForce(Vector3.forward * accelSpeed * Time.deltaTime);
        }
    }

    /*
    // Detect collision with another object
    void OnCollisionEnter(Collision other)  //  This code runs when actual collision is happening (When a hitbox lands on a hurtbox)
    {

        if (other.gameObject.CompareTag("Floor"))   // Other is a variable. Collision is a type. This if statement is the primary statement
        {
            Debug.Log("Colliding with Floor");
        }
        else if(other.gameObject.CompareTag("Obstacle"))   // An else if statement is a fallback plan. A plan B. You must have an if statement if you are to make an else if.
        {
            Debug.Log("Colliding with obstacle");
        }
        else  // This else statement is what will be defaulted to if both if and else if statements are not true
        {
            Debug.Log("...awaiting impact");
        }
    }

    void OnTriggerEnter(Collider Other)     //  This code runs when a trigger is activated (Cutscenes playing when a location is reached)
    {
        Debug.Log("You are enter trigger!");
    }
    */
}
