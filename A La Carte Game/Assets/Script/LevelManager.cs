using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    
    // Start is called before the first frame update
    public static LevelManager instance;
    public int angka;
    public List<string> Scene;
    private void Start()
    {

        angka = 0;
        Scene = new List<string>();
        Scene.Add("MainMenu");
        Scene.Add("Level 1");
        Scene.Add("Level 2");
        Scene.Add("Credit");
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        
    }
}
