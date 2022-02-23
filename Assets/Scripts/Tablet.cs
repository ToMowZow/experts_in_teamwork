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

    float countDownTimer = 300f;

    void Update()
    {
        countDownTimer -= Time.deltaTime;
        countDownTimerText.text = countDownTimer.ToString("F1");
    }
}