﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] float baseLives = 3;
    [SerializeField] int damage = 1;
    float lives = 5;
    Text livesText;

    void Start()
    {
        lives = baseLives - PlayerPrefController.GetDifficulty();
        livesText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }
    public void TakeLife()
    {
        lives -= damage;
        UpdateDisplay();
        
        if (lives <=0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
    }
}
