using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;

public class DistanceCheck : MonoBehaviour
{
    #region -------------- Variables --------------

    [SerializeField] private float threshold;
    public GameObject[] itemList;
    private Transform thisGameObject;
    private Vector3 thisObjectPosition;
    public bool allTrue;
    

    #endregion

    #region -------------- Setup --------------

    private void Start()
    {
        thisGameObject = GetComponent<Transform>();
        thisObjectPosition = thisGameObject.transform.position;
        loopThruObjects(itemList, thisObjectPosition);
       
    }

    #endregion

    #region -------------- Work --------------

    private void Update()
    {
        
    }

    #endregion

    #region -------------- Methods --------------

    private bool checkDistance(Vector3 one, Vector3 two, float distance)
    {
        bool isWithinRadius;
        if (Vector3.Distance(one, two) < distance)
        {
            isWithinRadius = true;
            Debug.Log(isWithinRadius);
            return isWithinRadius;
            
            
        }
        else
        {
            isWithinRadius = false;
            return isWithinRadius;
        }
    }

    public void loopThruObjects(GameObject[] objectArray, Vector3 object2)
    {
        allTrue = true;
        List<bool> allTrueArray = new List<bool>();
        foreach (var obj in objectArray)
        {
            allTrueArray.Add(checkDistance(obj.transform.position, object2, threshold));
            if (!checkDistance(obj.transform.position, object2, threshold))
            {
                
                allTrue = false;
            }
           
            
        }
        Debug.Log(allTrueArray.Count);
       
    }
    
    //use unity events to streamline process. 


    #endregion

    #region -------------- Visualize --------------



    #endregion

    #region -------------- Inspector --------------



    #endregion
}
