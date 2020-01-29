using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Here we go!");
    }

    // Update is called once per frame
    void Update()
    {

    }
    // Detect collision with another object
    void OnCollisionEnter(Collision other)  
    {

        if (other.gameObject.CompareTag("Track"))
        {
            Debug.Log("Wheeeeeeee!");
        }
        else if (other.gameObject.CompareTag("Wall"))
        {
            Debug.Log("Ow!");
        }
        else  
        {
            Debug.Log("I'm Flying!");
        }
    }

    void OnTriggerEnter(Collider Other)    
    {
        Debug.Log("Finish!");
    }
}
