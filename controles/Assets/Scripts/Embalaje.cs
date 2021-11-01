using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Embalaje : MonoBehaviour
{
    public GameObject cajita;
    public ItemInfo[] mueblesInfo;
    public Transform SpawnPoint;
    GameObject caja;
    
    private void OnCollisionEnter(Collision coll) 
    {
        //Debug.Log("Tocó");

        if (coll.transform.parent == null && coll.gameObject.tag == "Mueble"){  
          
          ObjetoInfo infoObjeto = coll.gameObject.GetComponent<ObjetoInfo>();
          ItemInfo infoItem = infoObjeto.info;

          //Debug.Log("Entró");

          if (infoItem == mueblesInfo[0])
          {
               Destroy(coll.gameObject);
               Embalando();

               caja = Instantiate(cajita, SpawnPoint.position, Quaternion.identity);
               caja.tag = "Caja Armario";
               FindObjectOfType<AudioManager>().Play("BreakingItem");
          }

          if (infoItem == mueblesInfo[1])
          {
               Destroy(coll.gameObject);
               Embalando();

               caja = Instantiate(cajita, SpawnPoint.position, Quaternion.identity);
               caja.tag = "Caja Lampara";
               FindObjectOfType<AudioManager>().Play("BreakingItem");
          }

          if (infoItem == mueblesInfo[2])
          {
               Destroy(coll.gameObject);
               Embalando();

               caja = Instantiate(cajita, SpawnPoint.position, Quaternion.identity);
               caja.tag = "Caja Mesa Noche";
               FindObjectOfType<AudioManager>().Play("BreakingItem");
          }

          if (infoItem == mueblesInfo[3])
          {
               Destroy(coll.gameObject);
               Embalando();

               caja = Instantiate(cajita, SpawnPoint.position, Quaternion.identity);
               caja.tag = "Caja Silla";
               FindObjectOfType<AudioManager>().Play("BreakingItem");
          }

          if (infoItem == mueblesInfo[4])
          {
               Destroy(coll.gameObject);
               Embalando();

               caja = Instantiate(cajita, SpawnPoint.position, Quaternion.identity);
               caja.tag = "Caja Sillon";
               FindObjectOfType<AudioManager>().Play("BreakingItem");
          }
        }
    }

     IEnumerator Embalando()
    {
        yield return new WaitForSeconds(5);
    }
}
