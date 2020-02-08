using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupFloat : MonoBehaviour
{

    // Set objects to float up and down while spinning
    public float degreesPerSecond = 15f;
    public float amplitude = 0.5f;
    public float frequency = 1f;

    // position storage for movement
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();


    // Start is called before the first frame update
    void Start()
    {
        // This will mark and record the starting position and rotation of the pickup for use in later variables
        posOffset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        // This makes it spin on the Y
        transform.Rotate(new Vector3(0f, Time.deltaTime * degreesPerSecond, 0f), Space.World);
        // This makes it float up and down using a Sin() algorithm
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = tempPos;
    }
}

