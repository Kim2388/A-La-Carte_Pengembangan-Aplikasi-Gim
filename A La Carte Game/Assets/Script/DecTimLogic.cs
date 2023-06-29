using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DecTimLogic : MonoBehaviour
{
    public static DecTimLogic instance;
    public int time;
    public PauseMenuLogic paused;
    private int counter;
    private TextMeshProUGUI text;
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


        if (time <= 0)
        {
            print("waktu habis");
        }
        if(time <= 10)
        {
            text.color = Color.red;
        }
        text.text = time.ToString();
    }
}
