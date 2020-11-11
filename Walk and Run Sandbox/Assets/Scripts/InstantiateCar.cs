using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCar : MonoBehaviour
{
    
    public GameObject Player;
    public GameObject Car;
 
    void Update ()
    {
        StartCoroutine(Spawn());
    }
    
    IEnumerator Spawn ()
    {
        yield return new WaitForSeconds (Random.Range (1, 600));
        Instantiate(Car);
        Debug.Log("spawn car");
    }
}

