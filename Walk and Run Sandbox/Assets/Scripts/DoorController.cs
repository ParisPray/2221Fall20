﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public DistanceCheck distanceCheck;
    
    public GameObject door;
    public ParticleSystem particleSystem;
    private void Start()
    {
        //EventManager.current.onDoorwayTriggerEnter += OnDoorwayOpen();
    }

    public void OnDoorwayOpen()
    {
        if(distanceCheck.allTrue)
        {
            Debug.Log("You win!");
            particleSystem.Play();
            door.transform.position = new Vector3(0, 3, 0);
        }
        
        
    }
}
