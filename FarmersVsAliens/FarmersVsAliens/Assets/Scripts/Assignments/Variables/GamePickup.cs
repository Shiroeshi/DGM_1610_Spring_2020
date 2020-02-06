using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePickup : MonoBehaviour
{

    public int pointsToAdd;
    public string pickupName;
    public string pickupType;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //check to see if trigger detected player and only player. colliding with any other object will not trigger the change
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreManager.AddPoints (pointsToAdd); //always add points first THEN destroy the object. if the other way around, nothing is going to happen and the object will be gone
            Destroy(gameObject);
            
        }
    }
}
