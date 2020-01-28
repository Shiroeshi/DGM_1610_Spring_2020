﻿using System.Collections;
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
                                // (x,y,z)

    }


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
}
