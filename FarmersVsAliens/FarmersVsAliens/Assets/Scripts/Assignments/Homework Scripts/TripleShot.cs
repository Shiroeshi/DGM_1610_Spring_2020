using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleShot : MonoBehaviour
{
    public float BulletFireRate;
    public Rigidbody projectilePrefab;
    public int NumberofBullets = 3;
    private float ProjectileOffset = 1.3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("mouse 0"))
        {
            StartCoroutine(Shoot());
        }
    }

    IEnumerator Shoot()
    {
        Vector3 Position = new Vector3(transform.position.x,
                                      transform.position.y + ProjectileOffset,
                                      transform.position.z);
        for (int i = 0; i < NumberofBullets; i++)
        {
            Instantiate(projectilePrefab,
                        Position,
                        Quaternion.identity);
            yield return new WaitForSeconds(BulletFireRate);
        }
    }
}
