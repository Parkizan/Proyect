using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ensamblaje : MonoBehaviour
{
    public Transform mueble;
    public GameObject asamblePoint1;
    public GameObject asamblePoint2;
    public GameObject asamblePoint3;
    int indexOfSlots = 1;

    private void OnTriggerEnter(Collider coll){

        Debug.Log(coll.gameObject);
        if (coll.gameObject.tag == "Objeto" && coll.transform.childCount > 0){
            switch (indexOfSlots){
                case 1:
                indexOfSlots++;
                    coll.transform.position = asamblePoint1.transform.position;
                    break;
                case 2:
                
                indexOfSlots++;
                    coll.transform.position = asamblePoint2.transform.position;
                    break;
                case 3:
                
                    coll.transform.position = asamblePoint3.transform.position;
                    //craft
                    break;
                    


            }
        }  

    }
    
    /*private void OnCollisionEnter(Collision coll)
    {
        
        

        if(other.transform.childCount > 0){
        mueble = other.gameObject.transform.GetChild(0);
        mueble = asamblePoint1.transform;
        other.gameObject.transform.SetParent(asamblePoint1.transform);
        }

        if(other.tag == "Objeto"){
        other.gameObject.transform.position = asamblePoint1.transform.position;
        }
    }*/
}
