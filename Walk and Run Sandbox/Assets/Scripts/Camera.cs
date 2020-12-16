using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera: MonoBehaviour
{
    public GameObject player;

    private Vector3 offset = new Vector3(-4, 40, -20);


    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}