using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointInfo : MonoBehaviour
{
    public bool hasObjectInIt = false;

    void Update()
    {
        if(transform.childCount == 0)
        {
            hasObjectInIt = false;
        }

        if(transform.childCount == 1)
        {
            hasObjectInIt = true;
        }

        //Debug.Log(hasObjectInIt);
    }

    /*public void objectHandler(bool objectStatus)
    {
        if (objectStatus)
        {
            hasObjectInIt = true;
        }
        else 
        {
            hasObjectInIt = false;
        }
    }*/



}
