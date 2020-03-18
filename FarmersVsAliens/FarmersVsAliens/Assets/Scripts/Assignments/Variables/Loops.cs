using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public int numEnemies = 5;
    public int cupsInTheSink = 10;

    // Start is called before the first frame update
    void Start()
    {
        // For loop
        for (int i = 0; i <= numEnemies; i++) // Defines the start and will run as long as i is smaller than number of enemies.
        {
            Debug.Log("Creating enemy number: " + i);
        }

        // While Loop
        while (cupsInTheSink > 0) // This will loop 10 times since cups in the sink was equated to 10.
        {
            Debug.Log("I've washed a cup!");
            cupsInTheSink--; // The minus minus will be adding 1 to the loop every time it is repeated.
        }

        // Do While Loop
        bool shouldContinue = false; // 2 equal signs is a comparison while 1 equal sign checks a value.

        do
        {
            print("Hello world");
        }
        while (shouldContinue == true);

        // Foreach Loop
        string[] strings = new string[3]; // These loops cannot repeat infinitely since it only does it for as many items are in the array

        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";

        foreach (string item in strings)
        {
            print(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
