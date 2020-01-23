using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 0.05f); //Using the f as the end identifies it as a float command so we dont have to make a variable to track it.
        

    }


    // Detect collision with another object
    void OnCollisionEnter(Collision other)  //  This code runs when actual collision is happening (When a hitbox lands on a hurtbox)
    {
        
    }

    void OnTriggerEnter(Collider Other)     //  This code runs when a trigger is activated (Cutscenes playing when a location is reached)
    {

    }
}
