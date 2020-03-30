using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprint_Wobble : MonoBehaviour
{
    public float duration;
    public float magnitude;
    public Vector3 originalPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("shift"))
        {
            Vector3 originalPosition = transform.position;
            float elapsed = 0f;

            while (elapsed < duration)
            {
                float x = Random.Range(-1f, 1f) * magnitude;
                float y = Random.Range(-1f, 1f) * magnitude;

                transform.position = new Vector3(x, y, -10f);
                elapsed += Time.deltaTime;
            }

        }

        transform.position = originalPosition;
    }
}

