using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuchMIssle : MonoBehaviour
{
                                    // This is all going to be applied to bullet/projectile prefabs.
    public int damage = 1;
    public int time = 5;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyBullet());  // Coroutines happen off on the side and can run in sync or out of sync with the main script.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))   // The next couple lines will only be executed when interacting with an object with the tag enemy.
        {
            var hit = other.gameObject;
            var health = hit.GetComponent<EnemyHealth>();  

            if (health != null)   // explanation:   If Health (is not equal to/below) 0...
            {
                health.TakeDamage(damage);      //  health in this context is the EnemyHealth that we set a couple of lines before.
                Debug.Log("Boi that hurt like a buttcheeck on a stick!");
            }
        }

       
    }

    IEnumerator DestroyBullet() //You cannot start a coroutine within your standard routines, i.e in your collision or update routines.
    {
        yield return new WaitForSeconds(time);  // the yield return will end up sending the information back into the coroutine for future reference.
        Destroy(gameObject);
    }
}
