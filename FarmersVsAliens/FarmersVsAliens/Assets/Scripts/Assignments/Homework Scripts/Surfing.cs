using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surfing : MonoBehaviour
{

    public float velocitySpeed = 10;
    public float accelSpeed = 10;
    private float power = 1000f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            GetComponent<Rigidbody>().AddForce(0, 0, power, ForceMode.Force);
        }
            
    }
}
