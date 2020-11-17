using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Health : MonoBehaviour
{
    public UnityEvent addhealthEvent, subtracthealthEvent, deathEvent;
    public floatData health;
    public GameObject enemy;
    public GameObject healthobj;
    public GameObject currentSpawnPoint;
    public CharacterController characterController;
    [SerializeField]  CharacterMover playerControllerScript;
   
    public void Start()
    {
        health.value = 3;
    
    }

    
    
    public void AddHealth()
    {
        if(health.value < 3)
        {
            health.value++;

        }
        
    }

    public void SubtractHealth()
    {
        health.value--;
        if (health.value <= 0)
        {
            deathEvent.Invoke();
        }
    }

    public void deathHealth()
    {
        characterController.enabled = false;
        transform.position = currentSpawnPoint.transform.position;
        health.value = 3f;
        characterController.enabled = true;
    }
    public void OnTriggerEnter(Collider other)
    {
      

        if (other.CompareTag("Health"))
        {
            
            AddHealth();
            Destroy(other);
            

        }

        if (other.CompareTag("Enemy"))
        {
            SubtractHealth();
        }

        if (other.CompareTag("Car"))
        {
            deathEvent.Invoke();
        }
    }
}
