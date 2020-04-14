using UnityEngine;

public class PMovement : MonoBehaviour
{
    // ALL THE DANG VARIABLES
    [Header("Input variables")]
    public Transform playerCam;
    public Transform orientation;
    
    private Rigidbody rb;

    [Header("Character Rotation")]
    private float xRotation;
    private float sensitivity = 50f;
    private float sensMultiplier = 1f;

    [Header("Movement")]
    public float moveSpeed = 4500;
    public float maxSpeed = 20;
    public bool grounded;
    public LayerMask whatGround;

    public float counterMovement = 0.175f;
    private float threshold = 0.01f;
    public float maxSlopeAngle = 35f;

    [Header("Jumping")]
    private bool jumpReady = true;
    private float jumpCooldown = 0.25f;
    public float jumpForce = 550f;

    [Header("Player Inputs")]
    private float x, y;
    private bool jumping, sprinting;

    // On start
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        MyInput();
        Look();
    }

    private void FixedUpdate()
    {
        Movement();
    }

    // Coroutines to find inputs
    private void MyInput()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        jumping = Input.GetKey("space");

        // This'll start sprint when pressed
        if (Input.GetKeyDown(KeyCode.LeftShift))
            StartSprint();
        if (Input.GetKeyUp(KeyCode.LeftShift))
            StopSprint();
    }
    // Tricky movement modifieers for certain situations
    private void Movement()
    {
        // Extra downward movement
        rb.AddForce(Vector3.down * Time.deltaTime * 10);

        // Something about velocity and current orientation
        Vector2 mag = FindVelRelativeToLook();
        float xMag = mag.x, yMag = mag.y;

        // Will jump when available
        if (jumpReady && jumping) Jump();

        // Max run speed
        float maxSpeed = this.maxSpeed;

        // If speed is past the max, this'll throttle it down
        if (x > 0 && xMag > maxSpeed) x = 0;
        if (x < 0 && xMag < -maxSpeed) x = 0;
        if (y > 0 && yMag > maxSpeed) y = 0;
        if (y < 0 && yMag < -maxSpeed) y = 0;

        // Other modifiers to make it faster/more dynamic in the air
        float multiplier = 1f, multiplierV = 1f;

        // Further air movement
        if (!grounded)
        {
            multiplier = 0.5f;
            multiplierV = 0.5f;
        }

        // Actual force to add movement
        rb.AddForce(orientation.transform.forward * y * moveSpeed * Time.deltaTime * multiplier * multiplierV);
        rb.AddForce(orientation.transform.right * x * moveSpeed * Time.deltaTime * multiplier);

    }
   
    private void Jump()
    {
        if (grounded && jumpReady)
        {
            jumpReady = false;

            // Higher jumps
            rb.AddForce(Vector2.up * jumpForce * 1.5f);

            //Dont let them jump again once falling
            Vector3 vel = rb.velocity;
            if (rb.velocity.y < 0.5f)
                rb.velocity = new Vector3(vel.x, 0, vel.z);
            else if (rb.velocity.y > 0)
                rb.velocity = new Vector3(vel.x, vel.y / 2, vel.z);

            Invoke(nameof(ResetJump), jumpCooldown);
        }
    }

    private void ResetJump()
    {
        jumpReady = true;
    }

    private float desiredX;
    private void Look()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.fixedDeltaTime * sensMultiplier;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.fixedDeltaTime * sensMultiplier;

        //Find current look rotation
        Vector3 rot = playerCam.transform.localRotation.eulerAngles;
        desiredX = rot.y + mouseX;

        //Rotate, and also make sure we dont over- or under-rotate.
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //Perform the rotations
        playerCam.transform.localRotation = Quaternion.Euler(xRotation, desiredX, 0);
        orientation.transform.localRotation = Quaternion.Euler(0, desiredX, 0);
    }

    /// Find the velocity relative to where the player is looking
    public Vector2 FindVelRelativeToLook()
    {
        float lookAngle = orientation.transform.eulerAngles.y;
        float moveAngle = Mathf.Atan2(rb.velocity.x, rb.velocity.z) * Mathf.Rad2Deg;

        float u = Mathf.DeltaAngle(lookAngle, moveAngle);
        float v = 90 - u;

        float magnitue = rb.velocity.magnitude;
        float yMag = magnitue * Mathf.Cos(u * Mathf.Deg2Rad);
        float xMag = magnitue * Mathf.Cos(v * Mathf.Deg2Rad);

        return new Vector2(xMag, yMag);
    }

    private bool IsFloor(Vector3 v)
    {
        float angle = Vector3.Angle(Vector3.up, v);
        return angle < maxSlopeAngle;
    }

    private bool cancellingGrounded;

    /// Handle ground detection
    private void OnCollisionStay(Collision other)
    {
        //Make sure we are only checking for walkable layers
        int layer = other.gameObject.layer;
        if (whatGround != (whatGround | (1 << layer))) return;

        //Iterate through every collision in a physics update
        for (int i = 0; i < other.contactCount; i++)
        {
            Vector3 normal = other.contacts[i].normal;
            if (IsFloor(normal))
            {
                grounded = true;
                cancellingGrounded = false;
                CancelInvoke(nameof(StopGrounded));
            }
        }
    }

    private void StopGrounded()
    {
        grounded = false;
    }

    private void StartSprint()
    {

    }

    private void StopSprint()
    {

    }

}
