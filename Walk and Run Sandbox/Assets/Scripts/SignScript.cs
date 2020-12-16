using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using UnityEngine.UI;


public class SignScript : MonoBehaviour
{
    public GameObject signText;
    bool isShowing = false;
    public UnityEvent clickEvent;
    public GameAction clickAction;


 

    // Update is called once per frame
    private void OnMouseOver()
    {

        if (Input.GetMouseButtonUp(0))
        {
            clickEvent.Invoke();
            clickAction.Raise();
            
        }
      
    }

}