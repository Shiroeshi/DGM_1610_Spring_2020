using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This has to come before the public class or else it will not compile correctly. This makes it a new menu item for creating objects.
[CreateAssetMenu(fileName ="New SO", menuName ="Scriptable Object")]
public class Obstacle : ScriptableObject
{
    // Overall this script is making a premade object with scripts that will interact uniformly. It's like a shortcut for adding a whole bunch of scripts for npc's


    public new string name; //This is the area for the name

    public string description;

    public GameObject model;

    public Color color;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
