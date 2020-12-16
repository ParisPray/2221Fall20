using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("game over!");
        Application.Quit();
    }
}
