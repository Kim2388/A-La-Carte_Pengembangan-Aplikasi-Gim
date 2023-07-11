using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenuLogic : MonoBehaviour
{
    public GameObject HelpView;
    public GameObject Pause;
    public bool isPause;
    public bool isFOL;
    public Button Home;
    public Button Resume;
    public Button Restart;
    public Button Help;
    public Button ExitHelp;
    public WinPanelLogic winPanelLogic;
    // Start is called before the first frame update
    void Start()
    {
        isFOL = false;
        isPause = false;
        Pause.SetActive(false);
        HelpView.SetActive(false);
        Home.onClick.AddListener(onHome);
        Resume.onClick.AddListener(onResume);
        Restart.onClick.AddListener(onRestart);
        ExitHelp.onClick.AddListener(onExitHelp);
        Help.onClick.AddListener(onHelp);

    }
    void onHelp()
    {
        HelpView.SetActive(true);
    }
    void onResume()
    {
        isPause = false;
    }
    void onRestart()
    {
        winPanelLogic.isRestart = true;
   
    }
    void onHome()
    {
        LevelManager.instance.angka = 0;
        SceneManager.LoadScene(LevelManager.instance.Scene[LevelManager.instance.angka]);
    }
    void onExitHelp()
    {
        HelpView.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if(!isFOL)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                isPause = !isPause;
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
        if(isFOL)
        {
            Time.timeScale = 0;
            isPause = true;
        }
    }
}
