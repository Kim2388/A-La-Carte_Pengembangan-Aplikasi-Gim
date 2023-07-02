using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> Star;
    public int StarGet;
    void Start()
    {
        for(int i = 0; i < Star.Count; i++)
        {
            Star[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {        
        if(StarGet != 0)
        {
            for (int i = 0; i < StarGet; i++)
            {
                Star[i].SetActive(true);
            }
        }
    }
}
