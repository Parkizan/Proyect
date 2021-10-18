using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    void Start()
    {
        MovimientosBasicos mov1 = Player1.GetComponent<MovimientosBasicos>();
        MovimientosBasicos mov2 = Player2.GetComponent<MovimientosBasicos>();
        mov1.enabled = false;
        mov2.enabled = false;
        //Time.timeScale = 0f;
    }

    void Update()
    {
        
    }

    public void Arrancar(){
        MovimientosBasicos mov1 = Player1.GetComponent<MovimientosBasicos>();
        MovimientosBasicos mov2 = Player2.GetComponent<MovimientosBasicos>();
        mov1.enabled = true;
        mov2.enabled = true;
    }
}
