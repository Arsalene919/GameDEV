﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Text ScoreText;
    public GameManager GM;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!(SceneManager.GetActiveScene().name == "SampleScene"))
            return;
        ScoreText.text = "Score: " + GM.Score.ToString();
    }
}
