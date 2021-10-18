using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mesacrafteo : MonoBehaviour
{
    /*CADA OBJETO, tiene un SCRIPT DE INFORMACION DE OBJECTO (ItemInfo)

     a la hora de introducir el objeto en la mesa, consigue el script ItemInfo y se FIJA que sea del mismo tipo que el ultimo
     objeto, y que si no hay ninguno no se fije. hacemos... un ARRAY de objetos los cuales estan en la mesa.
     Cuando llegue a la maxima capacidad, INSTANCIAR el objeto que corresponde al ItemInfo. */   

     public GameObject[] objetos;

    private void OnCollisionEnter(Collision other){
        if (other.gameObject.tag == "Objeto"){

            if (objetos.Length == 3) return;

            if (objetos[0] == null){
                //PONER OBJETO EN SU LUGAR

                objetos[0] = other.gameObject;
                return;
            }

            ObjetoInfo infoLastObjeto = objetos[objetos.Length - 1].GetComponent<ObjetoInfo>();
            ObjetoInfo infoOtroObjeto = other.gameObject.GetComponent<ObjetoInfo>();

            if (infoLastObjeto.info.tag == infoOtroObjeto.info.tag){
                //PONER OBJETO EN EL SIGUIENTE LUGAR

                objetos[objetos.Length] = other.gameObject;
                return;
            }




        }
    }

    private void Update(){
        if (objetos.Length == 3){
            //INSTANCIAR OBJETO      JUAN TE LA RE COMES

            //Instantiate(objetos[2].GetComponent<ObjetoInfo>().info.prefab, posicionCualquiera,RotacionCualquiera);

            foreach (GameObject objecto in objetos)
            {
                Destroy(objecto);
            }
            //objetos = new GameObject[];
            //matar el array
        }
    }
}
