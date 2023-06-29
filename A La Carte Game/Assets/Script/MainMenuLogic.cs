using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public Button start;
    public Button helpButton;
    public Button exitButton;
    public GameObject help;
    void Start()
    {
        start.onClick.AddListener(startMenu);
        helpButton.onClick.AddListener(helpMenu);
        exitButton.onClick.AddListener(exit);
        help.SetActive(false);
    }

    // Update is called once per frame
   
    void startMenu(){
        LevelManager.instance.angka += 1;
        SceneManager.LoadScene(LevelManager.instance.Scene[LevelManager.instance.angka]);
    }
    void helpMenu(){ 
       help.SetActive(true);
    }
    void exit()
    {
        help.SetActive(false);
    }
}
