using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveJ2 : MonoBehaviour
{
    public float verticalInput;
    public float horizontalInput;
    public Vector3 jumpVector;
    public float speed = 2f;
    public float turnSpeed = 50f;
    public float initialVelocity = 0.0f;
    public float finalVelocity = 500.0f;
    public float currentVelocity = 0.0f;
    public float accelRate = 10.0f;
    public float decelRate = 50.0f;
    public float power = 500.0f;
    public float accel = 10f;
    public bool isGrounded;
    private bool sprint;
    


    // Update is called once per frame
    void Update()
    {
        power = power + (Time.deltaTime * accel);

        verticalInput = Input.GetAxis("Vertical");  //GetAxis is keymapping. Input keeps track of the inputs within the argument. 
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput); //Using the f as the end identifies it as a float command so we dont have to make a variable to track it. 
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
           

            transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);

            GetComponent<Rigidbody>().AddForce(jumpVector, ForceMode.VelocityChange);

           //  currentVelocity = currentVelocity + (accelRate * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed * 2f;
            bool sprint = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && sprint)
        {
            speed / 2f;
            bool sprint = false;
        }

        currentVelocity = Mathf.Clamp(currentVelocity, initialVelocity, finalVelocity);
         
        // transform.Translate(0, 0, power);
    
    
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
        }
    }
}
    
    /* public float speed = 6.0f;
    public float gravity = -9.8f;

    private float verticalVelocity;
    private float jumpForce = 15f;
    private float gravityJump = 14f;

    private CharacterController _charController;

    // Start is called before the first frame update
    void Start()
    {
        _charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);

        movement.y = gravity;

        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        _charController.Move(movement);

        if (_charController.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalVelocity = jumpForce;
            }
        }

        Vector3 jumpVector = new Vector3(0, verticalVelocity, 0);
        _charController.Move(jumpVector * Time.deltaTime);
    }
    */

