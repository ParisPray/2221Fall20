using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public static TriggerArea current;
    public DistanceCheck distanceCheck;
    public Transform door;
    public DoorController doorController;
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other);
        distanceCheck.loopThruObjects(distanceCheck.itemList, door.position);
        if (distanceCheck.allTrue)
        {
            doorController.OnDoorwayOpen();
        }
        
        
    }

 

 
}
