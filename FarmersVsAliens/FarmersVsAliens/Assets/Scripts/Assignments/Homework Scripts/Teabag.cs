using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teabag : MonoBehaviour
{
    public float time = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("ctrl"))
        {
            transform.Translate(0, -.15f, 0 * Time.deltaTime);
        }
    }

    private IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        {
            transform.Translate(0, .15f, 0 * Time.deltaTime);
        }

        
    }

}
