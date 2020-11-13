using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CarMover : MonoBehaviour
{
    
    // set position to fix car spawn <3
    
    private Rigidbody carRigidbody;
    public float lifeTime;

    public float speed = 50f;

    // Start is called before the first frame update
    

    private IEnumerator Start()
    {
      
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}