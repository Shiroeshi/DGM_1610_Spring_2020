using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public static int score;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Game score: " + score);
    }

    public static void AddPoints(int pointsToAdd) //setting it as public makes it so that other codes can interact with this script.
    {
        score += pointsToAdd;
    }
}
