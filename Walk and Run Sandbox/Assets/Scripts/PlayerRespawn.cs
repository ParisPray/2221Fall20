using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public GameObject currentSpawnPoint;
    public IntData health;
    public CharacterController characterController;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();

    }

    void Update()
    {
        if (health.value <= 0)
        {
            characterController.enabled = false;
            transform.position = currentSpawnPoint.transform.position;
            health.value = 3;
            characterController.enabled = true;
        }
    }
}
