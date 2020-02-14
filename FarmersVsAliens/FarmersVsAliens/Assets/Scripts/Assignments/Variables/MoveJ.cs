using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveJ : MonoBehaviour
{
    public float speed = 2f;
    public float verticalInput;
    public float horizontalInput;
    public float turnSpeed = 50f;
    public float jumpHeight;
    public float jumpRate = 0.15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");  
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput); 
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);

        /*if(Input.GetKeyDown("space"))
        {
            
            transform.Translate(0, 6, 0 * Time.deltaTime);
        }
        */
        if (Input.GetKey("space"))
        {
            jumpHeight += jumpRate;
            transform.Translate(0, jumpHeight, 0 * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider Other)
    {
        Debug.Log("Finish!");
    }
}
