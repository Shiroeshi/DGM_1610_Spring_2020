using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // A string Holds the Text that is used. lower case beginning with a Capital later to divide.
        string firstName = "Jonathan";
        string lastName = "Alvarez";
        string middleName = "Esau";

        // Console.Write doesn't work in unity since we aren't sending this to a console but rather a game engine.
        Debug.Log(firstName + middleName + lastName);
    }

    // Update is called once per frame
    void Update()
    {
        // int assignes a variable with a number unless specified not to.
        int x = 5;
        int y = 12;

        /* Since I put this equation in the update portion of the code, it will
        continue to do this equation over and over until I tell it to stop */
        Debug.Log(x * y);
    }
}
