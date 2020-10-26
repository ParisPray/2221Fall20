using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Health : MonoBehaviour
{
    public UnityEvent addhealthEvent, subtracthealthEvent, deathEvent;
    public FloatData health;
    public GameObject enemy;
    public GameObject healthobj;
    public GameObject currentSpawnPoint;
    [SerializeField] PlayerController playerControllerScript;
   
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

    public void OnTriggerEnter(Collider other)
    {
      

        if (other.CompareTag("Health"))
        {
            
            AddHealth();
            

        }

        if (other.CompareTag("Enemy"))
        {
            SubtractHealth();
        }
    }

  

}
