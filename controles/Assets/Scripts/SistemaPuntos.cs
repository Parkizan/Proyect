using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemaPuntos : MonoBehaviour
{
    public int puntos1;
    public int puntos2;

    public Text puntosP1;
    public Text puntosP2;
    void Update(){

      GameManager gm = FindObjectOfType<GameManager>();
      Timer tm = gm.GetComponent<Timer>();

      if(tm.secondsLeft == 0 && tm.min == 0)
      {

         if (puntos1 > puntos2)
         {
            Debug.Log("Ganó el Player 1");
         }

         if (puntos1 < puntos2)
         {
            Debug.Log("Ganó el Player 2");
         }

         if (puntos1 == puntos2)
         {
            Debug.Log("Empate");
         }

      }

        puntosP1.text = puntos1.ToString();
        puntosP2.text = puntos2.ToString();
    }
}