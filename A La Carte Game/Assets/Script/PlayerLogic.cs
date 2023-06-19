using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerLogic : MonoBehaviour
{
    public float speed = 1.5f;
    private Rigidbody rb;
    private Vector3 posisiAwal;
    public Transform start;
    private AudioSource tabrak;
    public AudioSource heal;
    // Start is called before the first frame update


    void Start()
    {
        tabrak = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        posisiAwal = new Vector3(start.position.x + 1.5f,start.position.y + 2.5f ,start.position.z -1f);
        transform.position = posisiAwal;
        
    }
    // Update is called once per framea
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Respawn"))
        {
            transform.position = posisiAwal;
            heal.Play();
            DecTimLogic.instance.time -= 3;
        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            tabrak.Play();
        }
    }
    void Update()
    {
        
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(-1 *horizontalInput , 0f,-1 * verticalInput );
        if (  Input.GetKey(KeyCode.LeftShift))
        {
            rb.AddForce(movement * speed);
        }
        if (Input.GetKeyDown(KeyCode.R)) {
            transform.position = posisiAwal;
            heal.Play();
            DecTimLogic.instance.time -= 3;
        }
        
        rb.AddForce(movement);
    }
    
}
