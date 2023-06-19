using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static LevelManager instance;
    public int angka;
    private void Start()
    {
        angka = 1;
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
}
