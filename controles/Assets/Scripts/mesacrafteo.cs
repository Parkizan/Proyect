using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mesacrafteo : MonoBehaviour
{
    public GameObject[] points;
    public ObjetoInfo infoLastObjeto;

    public ObjetoInfo[] muebles;
    public GameObject[] mueble;

    /*CADA OBJETO, tiene un SCRIPT DE INFORMACION DE OBJECTO (ItemInfo)

     a la hora de introducir el objeto en la mesa, consigue el script ItemInfo y se FIJA que sea del mismo tipo que el ultimo
     objeto, y que si no hay ninguno no se fije. hacemos... un ARRAY de objetos los cuales estan en la mesa.
     Cuando llegue a la maxima capacidad, INSTANCIAR el objeto que corresponde al ItemInfo. */
    public int point = 0;

    //public GameObject 

     public List<GameObject> objetos = new List<GameObject>();

    private void OnCollisionEnter(Collision other){

        if (other.transform.parent == null && other.gameObject.tag == "Objeto")
        {
            /*objetos.Add(other.gameObject.GetComponent<GameObject>());
            objetos.Clear();//limpia la lista
            objetos.Remove(null);//por instancia
            objetos.RemoveAt(0);//remueve el obj en una posicion*/

            ObjetoInfo infoObjeto = other.gameObject.GetComponent<ObjetoInfo>();

            if (objetos.Count == 0){
                //PONER OBJETO EN LUGAR 1
                other.gameObject.GetComponent<Rigidbody>().useGravity = false;
                other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                other.gameObject.GetComponent<Collider>().isTrigger = true;

                other.transform.position = points[0].transform.position;

                other.gameObject.transform.SetParent(points[0].gameObject.transform);
                objetos.Add(other.gameObject);
                //infoObjeto = other.gameObject.GetComponent<ObjetoInfo>();
                infoLastObjeto = objetos[0].GetComponent<ObjetoInfo>();
                point++;
                return;
            }

            if (objetos.Count == 1 && point == 1 && infoLastObjeto == infoObjeto){
                //PONER OBJETO EN LUGAR 2
                other.gameObject.GetComponent<Rigidbody>().useGravity = false;
                other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                other.gameObject.GetComponent<Collider>().isTrigger = true;

                other.transform.position = points[1].transform.position;

                other.gameObject.transform.SetParent(points[1].gameObject.transform);
                objetos.Add(other.gameObject);
                //infoObjeto = other.gameObject.GetComponent<ObjetoInfo>();
                point++;
                return;
            }

            if (objetos.Count == 3 && point == 2 && infoLastObjeto == infoObjeto){
                //PONER OBJETO EN LUGAR 3
                other.gameObject.GetComponent<Rigidbody>().useGravity = false;
                other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                other.gameObject.GetComponent<Collider>().isTrigger = true;

                other.transform.position = points[2].transform.position;

                other.gameObject.transform.SetParent(points[2].gameObject.transform);
                objetos.Add(other.gameObject);
                point++;
                return;
            }

        }
    }

    private void Update(){

        if (objetos.Count == 3){

            Destroy(objetos[0]);
            Destroy(objetos[1]);
            Destroy(objetos[2]);

            StartCoroutine(Crafting());
            
            if(infoLastObjeto == muebles[0]){
                Instantiate(mueble[0], points[1].transform.position, Quaternion.identity);
            }

            if(infoLastObjeto == muebles[1]){
                Instantiate(mueble[1], points[1].transform.position, Quaternion.identity);
            }

            if(infoLastObjeto == muebles[2]){
                Instantiate(mueble[2], points[1].transform.position, Quaternion.identity);
            }

            if(infoLastObjeto == muebles[3]){
                Instantiate(mueble[3], points[1].transform.position, Quaternion.identity);
            }

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
    {   float time = 2f;
        WaitForSeconds wait = new WaitForSeconds(time);
        yield return wait;
    }

}
