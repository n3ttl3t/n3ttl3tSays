﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void SetScore(int i)
    {
        score = i - 1;
        if(score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}