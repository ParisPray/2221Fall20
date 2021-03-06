﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Force : MonoBehaviour
{
    private Rigidbody rBody;
    public Vector3 forces;

    public bool canRunOnStart;

    private void Start()
    {
        rBody = GetComponent<Rigidbody>();
        if (canRunOnStart)
        {
            OnApplyForce();
        }
    }

    public void OnApplyForce()
    {
        rBody.AddRelativeForce(forces);
    }
}
