using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject player;
    //public Transform target;
    private Rigidbody enemyRb;
    public float moveSpeed;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        //target = GameObject.Find("Player").transform; //We aren't storing the game object itself but rather its movements
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       // transform.LookAt(target);
       // transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    public void FixedUpdate()
    {
        // Add Force
        enemyRb.AddForce((player.transform.position - transform.position).normalized * moveSpeed);
    }
}
