using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    private int view = 1;
    private float nilaix, nilaiy, nilaiz, rotasix, rotasiy, rotasiz;
    // Start is called before the first frame update
    void Start()
    {
        nilaix = transform.position.x - player.position.x +1f;
        nilaiy = transform.position.y - player.position.y + 5f;
        nilaiz = transform.position.z - player.position.z;
        rotasix =  -145.8f;
        rotasiy = 25.864f;
        rotasiz = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            view += 1;
            if(view == 3)
            {
                view = 1;
            }
        }
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        if (Input.GetMouseButton(1))
        {
            rotasix += mouseX *2f;
            rotasiy += mouseY *2f;
        }
        if (view == 1)
        {
            transform.position = new Vector3(player.position.x + nilaix -3f, player.position.y + nilaiy, player.position.z + nilaiz);
            transform.rotation = Quaternion.Euler(rotasiy, rotasix, rotasiz);
        }
        else if(view ==2 )
        {
            transform.position = new Vector3(player.position.x + nilaix - 2f , player.position.y + nilaiy + 2f, player.position.z + 2f + nilaiz);
            transform.rotation = Quaternion.Euler(rotasiy, rotasix - 1f, rotasiz);
        }
    }
}
