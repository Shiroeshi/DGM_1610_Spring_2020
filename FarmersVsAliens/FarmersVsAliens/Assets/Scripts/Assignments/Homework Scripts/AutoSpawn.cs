using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSpawn : MonoBehaviour
{
    public GameObject[] enemyPrefabs; 
    public int enemyIndex;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("AutoCreate", 5f, 5f);
    }

 

    // Update is called once per frame
    void Update()
    {
        /* new WaitForSeconds(time * Time.deltaTime);
        Instantiate(enemyPrefabs[enemyIndex], new Vector3(0, 0, 0), enemyPrefabs[enemyIndex].transform.rotation);
        */

    }

   IEnumerator AutoCreate()
    {
        yield return new WaitForSeconds(time);
        Instantiate(enemyPrefabs[enemyIndex], new Vector3(0, 0, 0), enemyPrefabs[enemyIndex].transform.rotation);
    }
    
    

}
