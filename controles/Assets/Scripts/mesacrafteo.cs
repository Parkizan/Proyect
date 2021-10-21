using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mesacrafteo : MonoBehaviour
{
    public GameObject[] points;
    public ObjetoInfo infoLastObjeto;

    /*CADA OBJETO, tiene un SCRIPT DE INFORMACION DE OBJECTO (ItemInfo)

     a la hora de introducir el objeto en la mesa, consigue el script ItemInfo y se FIJA que sea del mismo tipo que el ultimo
     objeto, y que si no hay ninguno no se fije. hacemos... un ARRAY de objetos los cuales estan en la mesa.
     Cuando llegue a la maxima capacidad, INSTANCIAR el objeto que corresponde al ItemInfo. */
    public int point = 0;

     public List<GameObject> objetos = new List<GameObject>();

    private void OnCollisionEnter(Collision other){

        if (other.transform.parent == null && other.gameObject.tag == "Objeto")
        {
            /*objetos.Add(other.gameObject.GetComponent<GameObject>());
            objetos.Clear();//limpia la lista
            objetos.Remove(null);//por instancia
            objetos.RemoveAt(0);//remueve el obj en una posicion*/

            //if (objetos.Count == 3) return;
            ObjetoInfo infoObjeto = other.gameObject.GetComponent<ObjetoInfo>();

            if (objetos.Count == 0){
                //PONER OBJETO EN LUGAR 1
                other.transform.position = points[0].transform.position;
                
                objetos.Add(other.gameObject);
                infoObjeto = other.gameObject.GetComponent<ObjetoInfo>();
                infoLastObjeto = objetos[0].GetComponent<ObjetoInfo>();
                point++;
                return;
            }

            if (objetos.Count == 1 && point == 1 && infoLastObjeto == infoObjeto){
                //PONER OBJETO EN LUGAR 2
                other.transform.position = points[1].transform.position;
                objetos.Add(other.gameObject);
                infoObjeto = other.gameObject.GetComponent<ObjetoInfo>();
                point++;
                return;
            }

            if (objetos.Count == 3 && point == 2 && infoLastObjeto == infoObjeto){
                //PONER OBJETO EN LUGAR 3
                other.transform.position = points[2].transform.position;
                objetos.Add(other.gameObject);
                point++;
                return;
            }

        }
    }

    private void Update(){

        if (objetos.Count == 3){
            //ESPERAR COURTINE
            
            //INSTANCIAR OBJETO

            //Instantiate(objetos[2].GetComponent<ObjetoInfo>().info.prefab, posicionCualquiera,RotacionCualquiera);

            /*foreach (GameObject objecto in objetos)
            {
                Destroy(objecto);
            }*/
            //objetos = new GameObject[];
            //matar el array
        }
    }
}
