using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agarrar1 : MonoBehaviour
{
    private GameObject pickedObject;
    bool isHoldingSomething = false;
    public GameObject handPoint;
    //public string childFound;
    //private Transform item;

    private void OnTriggerStay(Collider other)
    {
            if (Input.GetKeyDown("g") && !isHoldingSomething && other.tag == "Objeto")
            {
                other.GetComponent<Rigidbody>().useGravity = false;
                other.GetComponent<Rigidbody>().isKinematic = true;
                other.GetComponent<Collider>().isTrigger = false;
                if (other.gameObject.GetComponentInParent<InstanciadorObjetos>()){
                    InstanciadorObjetos insta = other.transform.GetComponentInParent<InstanciadorObjetos>();
                    insta.hasObjectInIt = false;
                }
                other.transform.position = handPoint.transform.position;
                other.gameObject.transform.SetParent(handPoint.gameObject.transform);
                pickedObject = other.gameObject;
                FindObjectOfType<AudioManager>().Play("PickupObject");
                StartCoroutine(delayCopado());
                return;
            }
            if (Input.GetKeyDown("g") && isHoldingSomething)
            {
                other.GetComponent<Rigidbody>().useGravity = true;
                other.GetComponent<Rigidbody>().isKinematic = false;
                other.GetComponent<Collider>().isTrigger = true;
                other.transform.position = handPoint.transform.position;
                other.gameObject.transform.SetParent(null);
                pickedObject = null;
                FindObjectOfType<AudioManager>().Play("DropObject");
                StartCoroutine(delayCopado2());
                return;
            }
    }

    IEnumerator delayCopado()
    {
        yield return new WaitForSeconds(1f);
        isHoldingSomething = true;
    }

    IEnumerator delayCopado2()
    {
        yield return new WaitForSeconds(0.5f);
        isHoldingSomething = false;
    }




}
