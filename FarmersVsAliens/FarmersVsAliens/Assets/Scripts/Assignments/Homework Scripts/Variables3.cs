using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables3 : MonoBehaviour


{
    public string classOne = "Astronomy";
    public string classTwo = "3d Modeling";
    public string classThree = "2d Animation";

    // These forward slashes make it so that this comment is a single line

    /* the forward slash+asterisk make it so that 
     * multiple lines of code are seen as a comment, not just one */


    // Start is called before the first frame update
    void Start()
    {
    
        School(classOne, classTwo, classThree);

    }

    private void School(string classOne, string classTwo, string classThree)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
