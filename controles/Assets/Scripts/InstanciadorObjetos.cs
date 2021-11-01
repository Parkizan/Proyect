using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorObjetos : MonoBehaviour
{
  public bool hasObjectInIt = false;

  public Transform transfor;
  [SerializeField] float time = 5;

  public GameObject test;

    private void Update() {

        if (!hasObjectInIt) {
            //Coroutine instantiate 1 segundo
            StartCoroutine(spawnCycle());
        } 

        if (transform.childCount == 0){
            hasObjectInIt = false;
        }
        
        if (transform.childCount == 1){
            hasObjectInIt = true;
        }

    }


    IEnumerator spawnCycle(){
        WaitForSeconds wait = new WaitForSeconds(time);
        yield return wait;
        GameObject gm = Instantiate(test, transfor.position, test.transform.rotation);
        gm.transform.parent = gameObject.transform;
    }

    

    /*void objectHandler(bool objectStatus)
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
