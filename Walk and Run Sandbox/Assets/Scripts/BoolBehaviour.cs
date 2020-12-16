using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BoolBehaviour : MonoBehaviour
{
    public bool isActive;
    public UnityEvent clickEvent;

    public void Toggle()
    {
        isActive = !isActive;
    }
}
