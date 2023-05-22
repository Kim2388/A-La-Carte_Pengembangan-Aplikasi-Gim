using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    public float speed = 1.5f;
    private Rigidbody rb;
    private Vector3 posisiAwal;
    public Transform start;
    public Transform finish;
    public GameObject kotak;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        posisiAwal = new Vector3(start.position.x + 1.5f,start.position.y + 2.5f ,start.position.z -1f);
        transform.position = posisiAwal;
    }
    // Update is called once per framea
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(-1 *horizontalInput , 0f,-1 * verticalInput );
        if (  Input.GetKey(KeyCode.LeftShift))
        {
            rb.AddForce(movement * speed);
        }
        if (transform.position.y <= 3.5f || Input.GetKey(KeyCode.R)) {
            transform.position = posisiAwal;
        }
        if(transform.position.z <= finish.position.z) {
            
        
            print("sudah finish bro");
            
        }
        rb.AddForce(movement);
    }
    
}
