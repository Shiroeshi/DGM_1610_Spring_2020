using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public string goodFriends;
    public int starts;

    // Start is called before the first frame update
    void Start()
    {
        /* if (goodFriends == "Samantha")
         {
             print("Wanna sing something?");
         }
         else if (goodFriends == "Arec")
         {
             print("Wanna play some crucible?")
         }

         switch (goodFriends) // if any of the string values equals any of these values, it will print out the selected value. This is something we do manually.
         {
             case "Samantha":
                 print("Wanna sing something?");
                 break;

             case "Arec":
                 print("Wanna play soem crucible?");
                 break;

         }
         */
    }

    // Update is called once per frame
    void Update()
    {
        switch (goodFriends) // if any of the string values equals any of these values, it will print out the selected value. This is something we do manually.
        {
            case "Samantha":
                print("Wanna sing something?");
                break;

            case "Arec":
                print("Wanna play soem crucible?");
                break;

        }

        switch (starts)
        {
            case 1:
                print("something singing");
                break;
            case 2:
                print("something crucible");
                break;
            default:
                print("where are all my friends...");
                break;
        }
    }
}
