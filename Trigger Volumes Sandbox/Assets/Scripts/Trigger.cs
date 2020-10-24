using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    //
    public Color newColor;
    public Color defaultColor;
    private MeshRenderer meshR;
    public GameObject door;
    public bool IsVisible;


    void Start()
    {
        meshR = GetComponent<MeshRenderer>();
        meshR.material.color = defaultColor;
    }

    private void OnTriggerEnter(Collider other)
    {
        newColor.a = 1f;
        meshR.material.color = newColor;
        IsVisible = false;

    }

    private void OnTriggerExit(Collider other)
    {
        meshR.material.color = defaultColor;
        IsVisible = true;
        Debug.Log("Hi Marty!");
    }
}


