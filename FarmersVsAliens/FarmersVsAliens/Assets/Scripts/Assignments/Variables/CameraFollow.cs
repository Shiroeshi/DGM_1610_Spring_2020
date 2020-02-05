using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    GameObject playerChar;
    Vector3 cameraOffset;

    // Start is called before the first frame update
    void Start()
    {
        playerChar = GameObject.Find("playerChar");
        cameraOffset = new Vector3(0, 2, -5);  /* seting the Vector3 variable at the start will offset the position of the camera. 
                                                  Since it is put in Start and not Update, it will only do this translation once.*/
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerChar.transform.position + cameraOffset; // If you do not alter the position of the camera, the camera will be at the same positon, giving it a first person kind of view.
    }
}
