using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashBin : MonoBehaviour
{
    private void OnCollisionEnter(Collision coll) 
    {
        if (coll.transform.parent == null && coll.gameObject.tag == "Objeto"){
           
           Destroy(coll.gameObject);
        }
    }
}
