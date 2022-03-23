using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// Responsible for controlling the Tablet events and updating its timer.
/// </summary>
public class Tablet : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI countDownTimerText;
    [SerializeField] Animator warningAnimator;

    float countDownTimer = Constants.TotalWaveTime;
    bool timerStarted = false;

    void Start()
    {
        countDownTimerText.text = countDownTimer.ToString("F1");
        warningAnimator.speed = 0;
    }

    void Update()
    {
        if (!timerStarted) return;
        countDownTimer -= Time.deltaTime;
        countDownTimerText.text = countDownTimer.ToString("F1");
    }

    public void StartTimer()
    {
        timerStarted = true;
    }

    public void StartWarning()
    {
        warningAnimator.speed = 1;
    }
}