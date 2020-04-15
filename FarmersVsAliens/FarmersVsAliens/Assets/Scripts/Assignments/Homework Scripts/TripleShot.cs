using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleShot : MonoBehaviour
{
    public float BulletFireRate;
    public Rigidbody projectilePrefab;
    public int NumberofBullets = 3;
    private float ProjectileOffset = 1.3f;
    public Rigidbody player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("mouse 0"))
        {
            Instantiate(projectilePrefab, player.transform.position, projectilePrefab.transform.rotation);
            projectilePrefab.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 44444) * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
}

