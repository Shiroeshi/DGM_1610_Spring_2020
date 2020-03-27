﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySwitch : MonoBehaviour
{
    enum Gravity { up, down, left, right };
    
    Gravity gravityDirection;

    public Vector3[] gravityList = new Vector3[] { };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gravityList.Length < 5) { Debug.Log("gravity List is has to be more or exactly at 5"); return; }
        if (Input.KeyKeyDown("Y"))
         {
            //Restore
            Physics.gravity = gravityList[0];
        }
        if (Input.KeyKeyDown("U"))
        {
            Physics.gravity = gravityList[1];
        }
        if (Input.KeyKeyDown("I"))
        {
            Physics.gravity = gravityList[2];
        }
        if (Input.KeyKeyDown("O"))
        {
            Physics.gravity = gravityList[3];
        }
        if (Input.KeyKeyDown("P"))
        {
            Physics.gravity = gravityList[4];
        }
    }
}
