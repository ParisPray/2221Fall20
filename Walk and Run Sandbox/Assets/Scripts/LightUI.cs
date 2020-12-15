using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class LightUI : MonoBehaviour
{

    public Slider slider;
    private UnityEvent onProgressComplete;
    public float currentValue = 0f;
    public floatData timeLeft;

    public void Start()
    {
        timeLeft.value = 3;
    }

    public new float CurrentValue {
        get
        {
            return currentValue;
        }
        set {
            
            if (value >= slider.maxValue)
                onProgressComplete.Invoke();
            
        }
    }
    
   
    void Update ()
    {
        slider.value = timeLeft.value;
    }

    
   
}
