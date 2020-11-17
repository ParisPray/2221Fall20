using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCar : MonoBehaviour
{
    public GameObject Car;
    public GameObject carSpawnPoint;
    void Update ()
    {
        StartCoroutine(Spawn());
    }
    
    IEnumerator Spawn ()
    {
        yield return new WaitForSeconds (Random.Range (1, 12000));
        Car.transform.position = carSpawnPoint.transform.position;
        Instantiate(Car);
        Debug.Log("spawn car");
    }
}

