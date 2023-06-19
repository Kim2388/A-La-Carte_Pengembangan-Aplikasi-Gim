using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DecTimLogic : MonoBehaviour
{
    public static DecTimLogic instance;
    public int time;
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
        counter += 1;
        if (counter % 1000 == 0) { 
            time -= 1;
        }
        text.text = time.ToString();
        if (time <= 0)
        {
            print("waktu habis");
        }
    }
}
