using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    public float speed = 1.5f;
    private Rigidbody rb;
    private Vector3 posisiAwal;
    // Start is called before the first frame update
    void Start()
    {     
        rb = GetComponent<Rigidbody>();
        posisiAwal = new Vector3(transform.position.x,transform.position.y,transform.position.z);
    }
    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(-1 *horizontalInput , 0f,-1 * verticalInput );
        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.AddForce(movement * speed);
        }
        if (transform.position.y <= 3.55 || Input.GetKey(KeyCode.R)) {

            transform.position = posisiAwal;
        }
        rb.AddForce(movement);
    }
}
