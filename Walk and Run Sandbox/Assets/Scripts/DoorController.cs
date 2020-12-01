using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject door;
    public ParticleSystem particleSystem;
    private void Start()
    {
        EventManager.current.onDoorwayTriggerEnter += OnDoorwayOpen;
    }

    private void OnDoorwayOpen()
    {
        particleSystem.Play();
        door.transform.position = new Vector3(0, 3, 0);
        
    }
}
