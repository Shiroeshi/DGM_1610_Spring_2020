using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPickup : MonoBehaviour
{
    public double jumpHeight = 0.2f;
    
    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider Other)
    {
        if (Other.tag == "Player")
        {
            
        }
            
        Destroy(gameObject);
    }
}
