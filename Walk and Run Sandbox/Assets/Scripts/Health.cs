using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Health : MonoBehaviour
{
    public UnityEvent addhealthEvent, subtracthealthEvent, deathEvent;
    public IntData health;
    public GameObject enemy;
    public GameObject healthobj;
    public GameObject currentSpawnPoint;
    public GameObject trash1SpawnPoint;
    public GameObject trash2SpawnPoint;
    public GameObject trash3SpawnPoint;
    public CharacterController characterController;
    public GameObject trash1;
    public GameObject trash2;
    public GameObject trash3;
    public TrashSpawn TrashSpawn;
    public TrashPickup trashPickup;
    
  
    
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
        subtracthealthEvent.Invoke();
        health.value--;
        if (health.value <= 0)
        {
            deathEvent.Invoke();
        }
    }

    public void deathHealth()
    {
        trashPickup.throw_drop();
        health.value = 0;
        characterController.enabled = false;
        transform.position = currentSpawnPoint.transform.position;
        characterController.enabled = true;
        gameObject.transform.parent = null;
        trash1.transform.position = trash1SpawnPoint.transform.position;
        trash2.transform.position = trash2SpawnPoint.transform.position;
        trash3.transform.position = trash3SpawnPoint.transform.position;
        TrashSpawn.TrashRespawn();
        health.value = 3;



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
            subtracthealthEvent.Invoke();
        }

        if (other.CompareTag("Car"))
        {
            deathEvent.Invoke();
        }
    }
}
