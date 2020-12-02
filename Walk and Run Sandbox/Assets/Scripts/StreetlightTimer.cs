using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StreetlightTimer : MonoBehaviour
{
    public UnityEvent startEvent, counterdownEvent, deathEvent;
    float currCountdownValue;
    public IntData time;
    public int maxTime;
    private bool timerPaused = false;
    public StreetlightTimer current;
    

    public void Start()
    {
        time.value = maxTime;
        timerPaused = true;
    }
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("streetlight"))
        {
            timerPaused = false;
            StartCountdown();
        }
       
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("streetlight"))
        timerPaused = true;
        StopCountdown();
    }

    public void StartCountdown()
    {
        if (!timerPaused)
        {
            StartCoroutine(Countdown());
        }
    }

    public void StopCountdown()
    {
        if (timerPaused)
        {
            StopCoroutine(Countdown());
        }
    }

    public IEnumerator Countdown()
    {
        while (time.value > 0)
        {
            counterdownEvent.Invoke();
            yield return new WaitForSeconds(1.0f);
            time.value--;
            Debug.Log(time + "");
        }

        deathEvent.Invoke();
        
    }
}
