using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch2 : MonoBehaviour
{
    public string skateBoard;
    // Start is called before the first frame update
    void Start()
    {
        if (skateBoard == "Dinghy")
           {
               print("Wanna go for a casual cruise?");
           }
           else if (skateBoard == "Longboard")
           {
                print("Let's do some dancing!");
           }

            else if (skateBoard == "Skateboard")
            {
            print("Let's practice some tricks");
            }

           switch (skateBoard) 
           {
            case "Dinghy":
                print("Wanna go for a cruise?");
                   break;

            case "Skateboard":
                print("Let's practice some tricks");
                   break;

            case "Longboard":
                print("Let's do some dancing!");
                break;

           }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
