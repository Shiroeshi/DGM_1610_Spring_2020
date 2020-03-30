using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables2 : MonoBehaviour
{
    public float Breakfast;
    public float Lunch;
    public float Dinner;
    public float Snacks;
    public float Calories;
    public float Exercise;



    // Start is called before the first frame update
    void Start()
    {
    }

    private void Meals(float Breakfast, float Lunch, float Dinner, float Snacks, float Exercise)
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Calories;
        Calories = Breakfast + Lunch + Dinner + Snacks - Exercise;

        Console.WriteLine("I need to exercise more because I eat this many calories a day", Calories);
    }
}
