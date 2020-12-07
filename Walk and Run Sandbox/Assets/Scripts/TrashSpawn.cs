using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawn : MonoBehaviour
{
    public GameObject trash1;
    public GameObject trash2;
    public GameObject trash3;
    
    public GameObject trash1SpawnPoint;
    public GameObject trash2SpawnPoint;
    public GameObject trash3SpawnPoint;
    
    public void TrashRespawn()
    {
        trash1.transform.position = trash1SpawnPoint.transform.position;
        trash2.transform.position = trash2SpawnPoint.transform.position;
        trash3.transform.position = trash3SpawnPoint.transform.position;
        
    }
}
