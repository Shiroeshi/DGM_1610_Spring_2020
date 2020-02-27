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

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");  //GetAxis is keymapping. Input keeps track of the inputs within the argument. 
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput); //Using the f as the end identifies it as a float command so we dont have to make a variable to track it. 
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space))
        {
           

            transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);

            GetComponent<Rigidbody>().AddForce(jumpVector, ForceMode.VelocityChange);
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

