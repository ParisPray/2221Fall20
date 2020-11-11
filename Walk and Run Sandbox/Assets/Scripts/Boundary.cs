using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    public Color newColor;
    private MeshRenderer meshR;
    public GameObject boundary;
    public Color defaultColor;

    // Start is called before the first frame update
    void Start()
    {
        {
            meshR = GetComponent<MeshRenderer>();
            meshR.material.color = defaultColor;
        }

    }

    private void OnCollisionEnter(Collision other)
    {
        if (CompareTag("Player"))
        {
            boundary.SetActive(false);
        }

    }

    private void OnCollisionExit(Collision other)
    {
        if (CompareTag("Player"))
        {
            boundary.SetActive(true);
        }




    }
}

