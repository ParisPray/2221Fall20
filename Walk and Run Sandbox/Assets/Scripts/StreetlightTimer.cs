using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StreetlightTimer : MonoBehaviour
{
    public UnityEvent counterdownEvent, deathEvent;
    float currCountdownValue;
    public IntData time;
    public int maxTime;
    public float timertime;
    private bool timerPaused = false;
    public StreetlightTimer current;
    

    public void Start()
    {
        time.value = maxTime;
        timerPaused = true;
    }

    public void Update()
    {
        if (!timerPaused)
        {
            timertime += Time.deltaTime;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            timerPaused = false;
            Debug.Log("timer going");
            Countdown();
        }

    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            timerPaused = true;
            Debug.Log("timer paused");
        }
       
    }
    

    public IEnumerator Countdown()
    {
        while (time.value > 0)
        {
            counterdownEvent.Invoke();
            yield return new WaitForSeconds(1.0f);
            time.value--;
        }

        deathEvent.Invoke();
        
    }
}
