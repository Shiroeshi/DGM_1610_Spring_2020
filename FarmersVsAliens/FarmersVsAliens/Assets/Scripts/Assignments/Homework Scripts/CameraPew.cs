using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPew : MonoBehaviour
{
    public Rigidbody jumpyBoi;
    public float rotationSpeed = 6f;
    public float returnSpeed = 25f;

    public Vector3 RecoilRotation = new Vector3(2f, 2f, 2f); // Hipfire
    public Vector3 RecoilRotationAiming = new Vector3(0.5f, 0.5f, 1.5f); // Aiming
    public bool aiming;

    private Vector3 currentRotation;
    private Vector3 Rot;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("mouse 0"))
        {
            Fire();
        }   
        if (Input.GetButtonDown("Fire2"))
        {
            aiming = true;
        }
        else
        {
            aiming = false;
        }

    }

    public void FixedUpdate()
    {
        currentRotation = Vector3.Lerp(currentRotation, Vector3.zero, returnSpeed * Time.fixedDeltaTime);
        Rot = Vector3.Slerp(Rot, currentRotation, rotationSpeed * Time.fixedDeltaTime);
        // transform.localRotation* Quaternion.Euler(Rot);
    }

    public void Fire()
    {
        if (aiming)
        {
            currentRotation += new Vector3(-RecoilRotationAiming.x, Random.Range(-RecoilRotationAiming.y, RecoilRotationAiming.y), Random.Range(-RecoilRotationAiming.z, RecoilRotationAiming.z));
        }
        else
        {
            currentRotation += new Vector3(-RecoilRotation.x, Random.Range(-RecoilRotation.y, RecoilRotation.y), Random.Range(-RecoilRotation.z, RecoilRotation.z));
        }
    }
}
