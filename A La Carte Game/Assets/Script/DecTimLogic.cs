using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine.UIElements;

public class DecTimLogic : MonoBehaviour
{
    public static DecTimLogic instance;
    public int time;
    public PauseMenuLogic paused;
    public GameObject LosePanel;
    private int counter;
    private TextMeshProUGUI text;
    public StarLogic star;
    // Start is called before the first frame update

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        counter = 0;
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!paused.isPause) {
            counter++;
        }
        if (counter % 1000 == 0)
        {
            time -= 1;
        }

        if (time < 10)
        {
            star.StarGet = 1;
            text.color = Color.red;
            LosePanel.SetActive(false);

        }

        if (time >= 10 && time < 30 ) {
            star.StarGet = 2;
            text.color = Color.white;
            LosePanel.SetActive(false);

        }
        if (time >= 30  && time <= 60)
        {
            star.StarGet = 3;
            text.color = Color.white;
            LosePanel.SetActive(false);



        }

        if (time <= 0)
        {
            time = 0;
            paused.isFOL = true;
            LosePanel.SetActive(true);
        }
        text.text = time.ToString();
    }
}
