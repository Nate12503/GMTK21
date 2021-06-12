﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void NextScene()
    {
        MoveCounter.ResetMoves();
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1));
    }

    public static void ReloadScene()
    {
        MoveCounter.ResetMoves();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
