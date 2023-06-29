using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuLogic : MonoBehaviour
{
    public GameObject Pause;
    public bool isPause;
    
    // Start is called before the first frame update
    void Start()
    {
        isPause = false;
        Pause.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPause =  !isPause;
        }
        if (!isPause)
        {
            Pause.SetActive(false);
            Time.timeScale = 1;
        }
        if (isPause)
        {
            Pause.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
