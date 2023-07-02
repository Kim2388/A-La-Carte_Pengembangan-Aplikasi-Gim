using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinPanelLogicText : MonoBehaviour
{
    private TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = DecTimLogic.instance.time.ToString();
    }
}
