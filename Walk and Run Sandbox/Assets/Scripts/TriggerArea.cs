using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public static TriggerArea current;
    public bool isPickUp1;
    public bool isPickUp2;
    public bool isPickUp3;
    private void OnTriggerEnter(Collider other)
    {
        EventManager.current.DoorwayTriggerEnter();
        
        if (GameObject.Find("trash1"))
        {
            isPickUp1 = true;
        }
        if (GameObject.Find("trash2"))
        {
            isPickUp2 = true;
        }
        
        if (GameObject.Find("trash3"))
        {
            isPickUp3 = true;
        }
    }
    
}
