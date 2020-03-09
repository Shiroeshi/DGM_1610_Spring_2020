using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pew : MonoBehaviour
{
    public Rigidbody jumpyBoi;
    public float recoilUp;
    public float recoilSide;
    private AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("mouse 0"))
        {
            sound.Play();
        }   
    }
}
