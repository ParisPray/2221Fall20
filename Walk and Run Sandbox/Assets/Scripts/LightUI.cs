using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class LightUI : MonoBehaviour
{

    public Slider slider;
    public Text displayText;
    private UnityEvent onProgressComplete;
    public float currentValue = 0f;

    public new float CurrentValue {
        get
        {
            return currentValue;
        }
        set {
            // If the value exceeds the max fill, invoke the completion function
            if (value >= slider.maxValue)
                onProgressComplete.Invoke();
            
        }
    }
    
    void Start ()
    {
        CurrentValue = 0f;
        // Initialize onProgressComplete and set a basic callback
        if (onProgressComplete == null)
            onProgressComplete = new UnityEvent();
        onProgressComplete.AddListener(OnProgressComplete);
    }
	
    void Update () {
        CurrentValue += 0.0153f;
    }

    // The method to call when the progress bar fills up
    void OnProgressComplete() {
        Debug.Log("Progress Complete");
    }

}
