using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGeirangerManager : MonoBehaviour
{
    const float WaveAnimationTotalSeconds = 180; //How many from the rocks falling until the wave hits the shore.
    const string MiniGeirangerRockTag = "MiniGeirRock";

    [SerializeField] Animator waveAnimator;
    [SerializeField] Rigidbody[] fallingRocks;


    bool animationStarted = false;

    void Start()
    {
        waveAnimator.speed = 0;

        foreach (var fallingRock in fallingRocks)
        {
            fallingRock.isKinematic = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag(MiniGeirangerRockTag)) return;
        Destroy(other.gameObject, 0.5f);

        if (!animationStarted)
        {
            animationStarted = true;

            //The animation is about 7 seconds
            float animationSpeed = 7 / WaveAnimationTotalSeconds;
            waveAnimator.speed = animationSpeed;
        }
    }


    public void StartSimulation()
    {
        foreach (var fallingRock in fallingRocks)
        {
            fallingRock.isKinematic = false;
        }
    }
}