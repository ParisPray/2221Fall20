using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(CharacterController))]
public class jump : MonoBehaviour
{

    public float gravity = -9.81f;
    public Vector3 positionDirection;
    public CharacterController Controller;
    private float yVar;
    public IntData jumpInt;
    private int jumpCount;
    private readonly WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    public float jumpForce = 10f;
    private bool canMove = true;
    private floatData moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Controller = GetComponent<CharacterController>();
        StartCoroutine(Jump());
    }

    private IEnumerator Jump()
    {
        canMove = true;
        while (canMove)
        {
            yield return wffu;
            
            
            positionDirection.Set(0, yVar, 0);
            
            yVar += gravity * Time.deltaTime;
            

            if (Controller.isGrounded && positionDirection.y < 0)
            {
                yVar = -1f;
                jumpCount = 0;
            }

            if (Input.GetKeyDown(KeyCode.Space) && jumpCount < jumpInt.value)
            {
                yVar = jumpForce;
                jumpCount++;

            }

            positionDirection = transform.TransformDirection(positionDirection);
            Controller.Move((positionDirection) * Time.deltaTime);
        }
       
    }
}



