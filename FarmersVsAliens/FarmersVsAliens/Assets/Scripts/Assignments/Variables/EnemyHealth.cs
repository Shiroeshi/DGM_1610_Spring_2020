using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
                                    // This is all going to be applied to enemy prefabs.
    public int currentHealth;
    public int maxHealth = 3;
    public Transform spawnPoint;
    public int points;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth   // This sets us to always have max health at the beginning of the game.
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if(currentHealth <= 0)
        {
            //Keep score at 0
            currentHealth = 0;
            print("Enemy is die");
            // Add points to score for killing enemy
            //scoreManager.Addpoints(points);   we'll use this later
            // Move enemy to spawn point for restart
            transform.position = spawnPoint.position;
            transform.rotation = spawnPoint.rotation;
            // Restart enemy health
            currentHealth = maxHealth;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
