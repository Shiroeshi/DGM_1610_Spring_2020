using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // This will give it control to the overall interface


public class ScoreKeeper : MonoBehaviour
{
    public static int score;

    public int winScore;

    public Text winText;

    private Text scoreText;

    //On awake run this block of code
    void Awake()
    {
        Time.timeScale = 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();

        score = 0;

        winText.GetComponent<Text>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (score < 0)
            score = 0;
        scoreText.text = "" + score;

        //If player achieves the desired score, display this
        if(score >= winScore) //If you wanna do a finish line, change this to a collider rather than a score finder
        {
            print("Win Score Reached = " + score);
            winText.GetComponent<Text>().enabled = true;  // The wintext will only be showing after the desired score is achieved.
            Time.timeScale = 0;
        }
        // If player hits the Escape key return to start menu
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
    }
}
