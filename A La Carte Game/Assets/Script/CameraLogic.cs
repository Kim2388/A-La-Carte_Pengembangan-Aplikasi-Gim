using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    private float eye = 2f;
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
            if (!zoom)
            {
                transform.position = new Vector3(player.position.x + eye, player.position.y + eye, player.position.z + eye);
                zoom = true;
            }
            else
            {
                transform.position = new Vector3(player.position.x, player.position.y + 2.76f, player.position.z - 5f);
                zoom = false;
            }
        }

    }
}
