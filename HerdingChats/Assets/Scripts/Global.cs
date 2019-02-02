﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{

    public static Global Instance; //Creates a new instance if one does not yet exist

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject); //makes instance persist across scenes
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject); //deletes copies of global which do not need to exist, so right version is used to get info from
        }
    }


    //Tweakables
    public float playerSpeed = 5.0f;
    public float catMoveForce = 500.0f;
    public float catMoveTimeMax = 10.0f;
    public float catMoveTimeMin = 1.0f;
    public float catMoveSpeed = 5.0f;

    //Counters
    public int catsCought = 0;
}
