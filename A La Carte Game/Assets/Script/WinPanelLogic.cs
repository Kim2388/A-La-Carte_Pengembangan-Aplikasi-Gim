using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinPanelLogic : MonoBehaviour
{
    public Button Next;
    public Button Restart;
    public bool isRestart;


    // Start is called before the first frame update
    void Start()
    {
        Next.onClick.AddListener(onNext);
        Restart.onClick.AddListener(onRestart);

    }
    void onNext()
    {
        LevelManager.instance.angka += 1;
        SceneManager.LoadScene(LevelManager.instance.Scene[LevelManager.instance.angka]);
    }
    void onRestart()
    {
        isRestart = true;
    }
    // Update is called once per frame
}
