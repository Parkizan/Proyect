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
    }


    IEnumerator spawnCycle(){
        WaitForSeconds wait = new WaitForSeconds(time);
        hasObjectInIt = true;
        yield return wait;
        //instanciar
        Instantiate(test, transfor.position, transfor.rotation, transform);
            
    }

    void objectHandler(bool objectStatus)
    {
        if (objectStatus)
        {
            hasObjectInIt = true;
        }
        else 
        {
            hasObjectInIt = false;
        }
    }

}
