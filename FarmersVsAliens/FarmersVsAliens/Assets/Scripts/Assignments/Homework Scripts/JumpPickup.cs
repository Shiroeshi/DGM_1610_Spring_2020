using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPickup : MonoBehaviour
{
    public double jumpHeight = 0.2f;
    public GameObject pickupEffect;
    public float multiplyer = 1.4f;
    public float duration = 5f;
    
    
    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
            
       // Destroy(gameObject);
    }

    IEnumerator Pickup(Collider player)
    {
        // Spawn cool effect
        Instantiate(pickupEffect, transform.position, transform.rotation);
        // Do something to player
        MoveJ2 speed = player.GetComponent<MoveJ2>();
        speed.speed *= multiplyer;

        GetComponent<BoxCollider>().enabled = false;

        yield return new WaitForSeconds(duration);

        speed.speed /= multiplyer;
        // Destroy gameobject
        Destroy(gameObject);

    }
}
