using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionCaja : MonoBehaviour
{
    public static int num_Powerup = 0;
    //public InstanciadorCajas IC;
    //public Collision player;
    public Transform hand1;
    public Transform handp;
    
    /*void Start ()
    {
       //IC = GameObject.FindGameObjectWithTag("GameController").GetComponent<InstanciadorCajas>();
    }*/

    private void OnTriggerEnter(Collider other) {
    
	if(other.gameObject.tag == "Player")
    {
        //player = other;
        num_Powerup = Random.Range(1,6);
        Debug.Log(num_Powerup);
		Destroy(gameObject);
	}

    if (num_Powerup == 1){
       PowerUpSpeed(other);
    }

    if (num_Powerup == 2){
       PowerDownSpeed(other);
    }

    if (num_Powerup == 3){
       BorrarObjetoPropio(other);
    }

    if (num_Powerup == 4){
       BorrarObjetoAjeno(other);
    }

    if (num_Powerup == 5){
        PowerUpFuerza(other);
    }
        
  }
    
    private void PowerUpSpeed(Collider player)
    {
        //Debug.Log(player.gameObject);
        MovimientosBasicos mov = player.gameObject.GetComponent<MovimientosBasicos>();
        mov.SpeedUp();
        
    }

    private void PowerDownSpeed(Collider player)
    {
        //Debug.Log(player.gameObject);
        MovimientosBasicos mov = player.gameObject.GetComponent<MovimientosBasicos>();
        mov.SpeedDown();
    } 

    private void PowerUpFuerza(Collider player)
    {
        //Debug.Log(player.gameObject);
        GameObject player1 = GameObject.Find("Tester (1)");
        GameObject player2 = GameObject.Find("Tester (2)");

        if(player.gameObject.name == "Tester (1)"){
            KnockBack knock = player1.gameObject.GetComponent<KnockBack>();
            knock.KnockBackBuff();
        }

        if(player.gameObject.name == "Tester (2)"){
            KnockBack1 knock1 = player1.gameObject.GetComponent<KnockBack1>();
            knock1.KnockBackBuff();
        }
    }

    private void PowerDownFuerza()
    {
        //disminuye la fuerza del jugador
    }

    private void BorrarObjetoPropio(Collider player)
    {
        //Debug.Log(player.gameObject);
        hand1 = player.transform.Find("Hand");
        handp = hand1.Find("handPoint");
        ObjectManager obj = handp.gameObject.GetComponent<ObjectManager>();
        obj.BorrarMiObjeto();
    }

    private void BorrarObjetoAjeno(Collider player)
    {
        //Debug.Log(player.gameObject);
        GameObject player1 = GameObject.Find("Tester (1)");
        GameObject player2 = GameObject.Find("Tester (2)");

        if(player.gameObject.name == "Tester (1)"){
        hand1 = player2.transform.Find("Hand");
        handp = hand1.Find("handPoint");
        ObjectManager obj = handp.gameObject.GetComponent<ObjectManager>();
        obj.BorrarMiObjeto();
        }

        if(player.gameObject.name == "Tester (2)"){
        hand1 = player1.transform.Find("Hand");
        handp = hand1.Find("handPoint");
        ObjectManager obj = handp.gameObject.GetComponent<ObjectManager>();
        obj.BorrarMiObjeto();
        }
    }
}
