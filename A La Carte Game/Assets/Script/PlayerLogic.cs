using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    public float speed = 1.5f;
    private bool speedmode = false;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {     
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput , 0f, verticalInput );
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speedmode = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speedmode = false;
        }
        if (speedmode) {
            rb.AddForce(movement * speed);
        }
        rb.AddForce(movement);
    }
}
