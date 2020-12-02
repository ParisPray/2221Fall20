using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public static TriggerArea current;
    private void OnTriggerEnter(Collider other)
    {
        if (GameObject.Find("trash1") && GameObject.Find("trash2")&&(GameObject.Find("trash3")))
        {
            EventManager.current.DoorwayTriggerEnter();
        }
        
        
    }

 
}
