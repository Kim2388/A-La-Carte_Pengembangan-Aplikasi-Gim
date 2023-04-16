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
            zoom = !zoom;
        }

        if (zoom)
        {
            transform.position = new Vector3(player.position.x + eye, player.position.y + eye, player.position.z + eye);
            transform.rotation = Quaternion.identity;
        }
        else
        {
            transform.position = new Vector3(player.position.x, player.position.y + 3.76f, player.position.z - 5f);
            transform.rotation = Quaternion.Euler(38.874f, 0, 0);
        }
    }
}
