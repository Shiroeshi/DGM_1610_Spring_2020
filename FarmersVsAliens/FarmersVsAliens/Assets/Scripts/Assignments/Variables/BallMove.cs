using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMove : MonoBehaviour
{

    public float speed;
    public Text countText;
    public Text yeetRoyale;

    private Rigidbody rb;
    private int yeets;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        yeets = 0;
        SetCountText();
        yeetRoyale.text = "";

    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Pick up"))
        {
            Destroy(other.gameObject);
            yeets = yeets + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Total Yeets: " + yeets.ToString();
        if (yeets >= 11)
        {
            yeetRoyale.text = "#1 Yeet Royale!";
        }
    }
}
