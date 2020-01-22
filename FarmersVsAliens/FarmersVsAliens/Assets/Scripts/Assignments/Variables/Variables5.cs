using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     float meN = 5;
     float womeN = 10;
     float childreN = 20;

     int candY = 20;

        People(meN, womeN, childreN);

        Debug.Log(candY > meN + womeN + childreN);
    }

    private void People(float meN, float womeN, float childreN)
    {
        throw new NotImplementedException();
       
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
