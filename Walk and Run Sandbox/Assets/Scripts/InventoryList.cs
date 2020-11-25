using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class InventoryList : MonoBehaviour
{
    
    List<GameObject> goList= new List<GameObject>();
  
    // Update is called once per frame
    private void OnCollisionEnter(Collision other)
    {
        
 
            if (gameObject.name == "trash1") { 
                goList.Add(new GameObject("trash1"));
                Destroy(gameObject);
                Debug.Log("trash1 acquired");
            }
        
            if (gameObject.name == "trash2") { 
                goList.Add(new GameObject("trash2"));
                Destroy(gameObject);
                Debug.Log("trash2 acquired");
            }
            
            if (gameObject.name == "trash3") { 
                goList.Add(new GameObject("trash3"));
                Destroy(gameObject);
                Debug.Log("trash3 acquired");
            }
    }
}
