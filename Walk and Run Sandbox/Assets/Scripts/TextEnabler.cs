using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextEnabler : MonoBehaviour
{
    public BoolBehaviour boolBehaviour;
    private bool textEnabled;
    public Text signText;
    public Image signBack;

    private void Start()
    {
        textEnabled = boolBehaviour.isActive;
        signText = GetComponent<Text>();
    }

    /*
    private void Update()
    {
        signText.enabled = textEnabled;
    }
    */

    public void toggleText()
    {
        
        signText.enabled = !signText.enabled;
        signBack.enabled = !signBack.enabled;
    }
}
