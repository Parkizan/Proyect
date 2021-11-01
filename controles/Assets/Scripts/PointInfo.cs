using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointInfo : MonoBehaviour
{

    [SerializeField] mesacrafteo mesacrafteo;
    public bool hasObjectInIt = false;
    bool lastObjectState = false;
    [SerializeField] int position;

    void Update()
    {
        if(transform.childCount == 1)
        {
            hasObjectInIt = true;
        } else if (transform.childCount == 0){

            hasObjectInIt = false;
        }


        if (lastObjectState == hasObjectInIt) return;

        if (!hasObjectInIt){
            mesacrafteo.RemoveObject(position);
        }

        lastObjectState = hasObjectInIt;


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
