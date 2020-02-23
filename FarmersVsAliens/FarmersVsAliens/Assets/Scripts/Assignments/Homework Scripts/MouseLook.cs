using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 100f;
    public Transform playerBody;
    private float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // This will remove the cursor from the screen so that we don't accidentally click outside of the window.
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; //The difference between doing mouse x and horizontal is that this will track the mouses movement and not the arrow keys.
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY; // Making this += will give this an inverted y looking layout.
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // This clamp makes sure that the camera doesn't go beyond a 180 degree angle and cause clipping with the camera.

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
