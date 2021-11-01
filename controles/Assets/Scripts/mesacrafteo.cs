using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mesacrafteo : MonoBehaviour
{
    public GameObject[] points;
    public ObjetoInfo infoLastObjeto;
    public ItemInfo lastItemInfo;
    public ItemInfo[] mueblesInfo;
    public GameObject[] muebleObject;

    /*CADA OBJETO, tiene un SCRIPT DE INFORMACION DE OBJECTO (ItemInfo)

     a la hora de introducir el objeto en la mesa, consigue el script ItemInfo y se FIJA que sea del mismo tipo que el ultimo
     objeto, y que si no hay ninguno no se fije. hacemos... un ARRAY de objetos los cuales estan en la mesa.
     Cuando llegue a la maxima capacidad, INSTANCIAR el objeto que corresponde al ItemInfo. */
     //public int point = 0;
     public List<GameObject> objetos = new List<GameObject>();

    private void OnCollisionEnter(Collision other){

        if (other.transform.parent == null && other.gameObject.tag == "Objeto")
        {
            /*objetos.Add(other.gameObject.GetComponent<GameObject>());
            objetos.Clear();//limpia la lista
            objetos.Remove(null);//por instancia
            objetos.RemoveAt(0);//remueve el obj en una posicion*/

            ObjetoInfo infoObjeto = other.gameObject.GetComponent<ObjetoInfo>();
            ItemInfo infoItem = infoObjeto.info;

            if (objetos.Count == 0){
                //PONER OBJETO EN LUGAR 1
                objetos.Add(other.gameObject);
                other.gameObject.GetComponent<Rigidbody>().useGravity = false;
                other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                other.gameObject.GetComponent<Collider>().isTrigger = true;

                other.transform.position = points[0].transform.position;

                other.gameObject.transform.SetParent(points[0].gameObject.transform);
                //infoObjeto = other.gameObject.GetComponent<ObjetoInfo>();
                infoLastObjeto = objetos[0].GetComponent<ObjetoInfo>();
                lastItemInfo = infoLastObjeto.info;
                return;
            }

            if (objetos.Count == 1 && lastItemInfo == infoItem){
                //PONER OBJETO EN LUGAR 2
                objetos.Add(other.gameObject);
                other.gameObject.GetComponent<Rigidbody>().useGravity = false;
                other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                other.gameObject.GetComponent<Collider>().isTrigger = true;

                other.transform.position = points[1].transform.position;

                other.gameObject.transform.SetParent(points[1].gameObject.transform);
                //infoObjeto = other.gameObject.GetComponent<ObjetoInfo>();
                return;
            }

            if (objetos.Count == 2 && lastItemInfo == infoItem){
                //PONER OBJETO EN LUGAR 3
                objetos.Add(other.gameObject);

                other.gameObject.GetComponent<Rigidbody>().useGravity = false;
                other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                other.gameObject.GetComponent<Collider>().isTrigger = true;

                other.transform.position = points[2].transform.position;

                other.gameObject.transform.SetParent(points[2].gameObject.transform);
                return;
            }

        }
    }

    void Update(){

        PointInfo p1 = points[0].GetComponent<PointInfo>();
        PointInfo p2 = points[1].GetComponent<PointInfo>();
        PointInfo p3 = points[2].GetComponent<PointInfo>();

        if (p1.hasObjectInIt == false && objetos.Count == 1)
        {
            objetos.RemoveAt(0);
        }

        if (p2.hasObjectInIt == false && objetos.Count == 2)
        {
            objetos.RemoveAt(1);
        }

        if (p3.hasObjectInIt == false && objetos.Count == 3)
        {
            objetos.RemoveAt(2);
        }
        
        if (objetos.Count == 3){
            
            if(lastItemInfo == mueblesInfo[0]){
                StartCoroutine(Crafting());
                Instantiate(muebleObject[0], points[1].transform.position, Quaternion.identity);
            }

            if(lastItemInfo == mueblesInfo[1]){
                StartCoroutine(Crafting());
                Instantiate(muebleObject[1], points[1].transform.position, Quaternion.identity);
            }

            if(lastItemInfo == mueblesInfo[2]){
                StartCoroutine(Crafting());
                Instantiate(muebleObject[2], points[1].transform.position, Quaternion.identity);
            }

            if(lastItemInfo == mueblesInfo[3]){
                StartCoroutine(Crafting());
                Instantiate(muebleObject[3], points[1].transform.position, Quaternion.identity);
            }

            if(lastItemInfo == mueblesInfo[4]){
                StartCoroutine(Crafting());
                Instantiate(muebleObject[4], points[1].transform.position, Quaternion.identity);
            }

            Destroy(objetos[0]);
            Destroy(objetos[1]);
            Destroy(objetos[2]);

            objetos.Clear();

            //Instantiate(objetos.)
            //InfoLastObjeto.prefab


            //Instantiate(objetos[2].GetComponent<ObjetoInfo>().info.prefab, posicionCualquiera,RotacionCualquiera);
            //objetos.Clear();

            /*foreach (GameObject objecto in objetos)
            {
                Destroy(objecto);
            }*/
            //objetos = new GameObject[];
            //matar el array
        }
    }

    IEnumerator Crafting()
    { 
        yield return new WaitForSeconds(5);
    }

}
