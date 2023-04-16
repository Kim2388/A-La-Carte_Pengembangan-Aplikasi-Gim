using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    private int view = 1;
    private bool zoom = false;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(player.position.x, player.position.y + 2.76f, player.position.z - 5f);
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

        if (view == 1)
        {
            transform.rotation = Quaternion.Euler(38.874f, 0f, 0f);
            transform.position = new Vector3(player.position.x, player.position.y + 3.76f, player.position.z - 5f);
            
        }
        else if(view ==2 )
        {
            transform.position = new Vector3(player.position.x, player.position.y + 7.76f, player.position.z - 5f);
            transform.rotation = Quaternion.Euler(60f,0f,0f);
        }
    }
}
