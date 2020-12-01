﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class EventManager : MonoBehaviour
{

    public static EventManager current;

    private void Awake()
    {
        current = this;
    }

    public event Action onDoorwayTriggerEnter;

    public void DoorwayTriggerEnter()
    {
        if (onDoorwayTriggerEnter != null && TriggerArea.current.isPickUp1 == true && TriggerArea.current.isPickUp2 == true && TriggerArea.current.isPickUp3 == true )
        {
            onDoorwayTriggerEnter();
        }
    }
}