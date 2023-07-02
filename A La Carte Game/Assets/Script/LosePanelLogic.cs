using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class LosePanelLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public Button Home;
    public Button Restart;
    void Start()
    {
        Home.onClick.AddListener(onHome);
        Restart.onClick.AddListener(onRestart);
    }
    void onHome()
    {
        LevelManager.instance.angka = 2;
        SceneManager.LoadScene(LevelManager.instance.Scene[LevelManager.instance.angka]);
    }
    void onRestart()
    {
        SceneManager.LoadScene(LevelManager.instance.Scene[LevelManager.instance.angka]);
    }
    // Update is called once per frame
    
}
