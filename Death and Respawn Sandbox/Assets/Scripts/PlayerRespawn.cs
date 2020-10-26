using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public GameObject currentSpawnPoint;
    public FloatData health;
    public CharacterController characterController;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();

    }

    void Update()
    {
        if (health.value <= 0f)
        {
            characterController.enabled = false;
            transform.position = currentSpawnPoint.transform.position;
            health.value = 3f;
            characterController.enabled = true;
        }
    }

   
}
