using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class ScoreDisplay : MonoBehaviour
{
    private TMP_Text _scoreDisplay;
    private int _score = 0;
    private float scoreTick;

    private void Start()
    {
        _scoreDisplay = GetComponent<TMP_Text>();
        _scoreDisplay.text = $"Счёт: {_score}";
    }

    private void FixedUpdate()
    {        
        scoreTick += Time.fixedDeltaTime;

        if (scoreTick >= 1)
        {
            _score++;
            _scoreDisplay.text = $"Счёт: {_score}";
            scoreTick = 0;
        }
            
    }
}
