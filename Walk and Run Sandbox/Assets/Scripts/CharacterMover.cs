﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 movement;

    public float rotateSpeed = 30f, gravity = -9.81f, jumpForce = 10f;
    private float yVar;

    public floatData normalSpeed, fastSpeed;
    private floatData moveSpeed;
    private bool canMove = true;
    
    public IntData playerJumpCount;
    private int jumpCount;


    private void Start() 
    {
        moveSpeed = normalSpeed;
        controller = GetComponent<CharacterController>();
        StartCoroutine(Move());
    }

    private readonly WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    private IEnumerator Move()
    {
        canMove = true;
        while (canMove)
        {
            
            yield return wffu;
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                moveSpeed = fastSpeed;
            }

           
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                moveSpeed = normalSpeed;
            
            }
        
            var vInput = Input.GetAxis("Vertical")*moveSpeed.value;
            
            movement.Set(vInput,yVar,0);
        
            var hInput = Input.GetAxis("Horizontal")*Time.deltaTime*rotateSpeed;
            transform.Rotate(0,hInput,0);

            yVar += gravity*Time.deltaTime;

            if (controller.isGrounded && movement.y < 0)
            {
                yVar = -1f;
                jumpCount = 0;
               

            }

            if (Input.GetButtonDown("Jump") && jumpCount < playerJumpCount.value)
            {
               
                yVar = jumpForce;
                jumpCount++;
                
            }
        
            movement = transform.TransformDirection(movement);
            controller.Move((movement) * Time.deltaTime);
        }
    }
    
}

   

