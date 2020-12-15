using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class timerScript : MonoBehaviour
{
    public floatData timeLeft;
    public bool timerIsRunning = false;
    public UnityEvent deathEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            timerIsRunning = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            timerIsRunning = false;
        }
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeLeft.value > 0)
            {
                timeLeft.value -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out!");
                timeLeft.value = 0;
                timerIsRunning = false;
                deathEvent.Invoke();
                timeLeft.value = 3;

            }
        }
    }
}
