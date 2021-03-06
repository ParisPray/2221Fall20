﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashPickup : MonoBehaviour
{
    public static TrashPickup current;
    public float speed = 10;
    public bool canHold = true;
    public static GameObject ball;
    public Transform guide;
   
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!canHold)
                throw_drop();
            else
                Pickup();
        }
  
        if (!canHold && ball)
            ball.transform.position = guide.position;
       
    }
 
    
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "ball")
            if (!ball) 
                ball = col.gameObject;
    }
 
    
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "ball")
        {
            if (canHold)
                ball = null;
        }
    }
 
 
    private void Pickup()
    {
        
        
        if (!ball)
            return;
        
        ball.transform.SetParent(guide);
        
        ball.GetComponent<Rigidbody>().useGravity = false;
        ball.transform.localRotation = transform.rotation;
        ball.transform.position = guide.position;
        canHold = false;
        Debug.Log("CanHold on" + canHold);


    }
 
    public void throw_drop()
    {
        
        if (!ball)
            return;

        ball.transform.parent = null;
        //guide.GetChild(0).parent = null;
        ball.GetComponent<Rigidbody>().useGravity = true;
        ball = null;
        guide.GetChild(0).gameObject.GetComponent<Rigidbody>().velocity = transform.forward * speed;
        canHold = true;
        

    }
    }

