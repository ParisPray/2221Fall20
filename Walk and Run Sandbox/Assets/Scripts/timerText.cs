using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class timerText : MonoBehaviour
{
    public IntData time;
    public Text timerUI;

    public void DisplayTimer()
    {
        timerUI.text = time.value.ToString();
    }
}
