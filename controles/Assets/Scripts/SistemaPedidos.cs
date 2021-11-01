using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemaPedidos : MonoBehaviour
{
    int cantPedidos1;
    int cantPedidos2;

    public string interno1;
    public string interno2;
    public string interno3;
    public string interno4;

    bool ocupado1;
    bool ocupado2;
    bool ocupado3;
    bool ocupado4;

    public Text pedido;
    public Text pedido2;
    public Text pedido3;
    public Text pedido4;

    int pedidonumero1;
    int pedidonumero2;

    void Start()
    {
        StartCoroutine(ActualizarPedidos1());
        StartCoroutine(ActualizarPedidos2());
    }

    void Update()
    {
        if (cantPedidos1 <= 1)
        {
            pedidofuncion1();
        }

        if (cantPedidos2 <= 1)
        {
            pedidofuncion2();
        }
    }


    IEnumerator ActualizarPedidos1()
    {
        yield return new WaitForSeconds(5);
        pedidofuncion1();
    }

    IEnumerator ActualizarPedidos2()
    {
        yield return new WaitForSeconds(5);
        pedidofuncion2();
    }

    private void pedidofuncion1(){
        //Random.seed = (int)System.DateTime.Now.Ticks;
        // Random.Range(int floor, int ceiling);
        pedidonumero1 = Random.Range(1,6);
        //Debug.Log("Random seed = " + numeroAleatorio);

        if (pedidonumero1 == 1)
        {
            if (ocupado2 == false)
            {
                pedido2.text = "Lampara";
                ocupado2 = true;
                interno2 = "Caja Lampara";

                cantPedidos1++;
            }
            else if (ocupado1 == false)
            {
                pedido.text = "Lampara";
                ocupado1 = true;
                interno1 = "Caja Lampara";

                cantPedidos1++;
            }
        }
        
        if (pedidonumero1 == 2)
        {
            if (ocupado2 == false)
            {
                pedido2.text = "Silla";
                ocupado2 = true;
                interno2 = "Caja Silla";
                cantPedidos1++;
            }
            else if (ocupado1 == false)
            {
                pedido.text = "Silla";
                ocupado1 = true;
                interno1 = "Caja Silla";
                cantPedidos1++;
            }
        }

        if (pedidonumero1 == 3)
        {
            if (ocupado2 == false)
            {
                pedido2.text = "Mesa Noche";
                ocupado2 = true;
                interno2 = "Caja Mesa Noche";
                cantPedidos1++;
            }
            else if (ocupado1 == false)
            {
                pedido.text = "Mesa Noche";
                ocupado1 = true;
                interno1 = "Caja Mesa Noche";
                cantPedidos1++;
            }
        }

        if (pedidonumero1 == 4)
        {
            if (ocupado2 == false)
            {
                pedido2.text = "Armario";
                ocupado2 = true;
                interno2 = "Caja Armario";
                cantPedidos1++;
            }
            else if (ocupado1 == false)
            {
                pedido.text = "Armario";
                ocupado1 = true;
                interno1 = "Caja Armario";
                cantPedidos1++;
            }
        }

        if (pedidonumero1 == 5)
        {
            if (ocupado2 == false)
            {
                pedido2.text = "Sillon";
                ocupado2 = true;
                interno2 = "Caja Sillon";
                cantPedidos1++;
            }
            else if (ocupado1 == false)
            {
                pedido.text = "Sillon";
                ocupado1 = true;
                interno1 = "Caja Sillon";
                cantPedidos1++;
            }
        }
    }
    
    private void pedidofuncion2(){
        //Random.seed = (int)System.DateTime.Now.Ticks;
        //Random.Range(int floor, int ceiling);
        pedidonumero2 = Random.Range(1,6);
        //Debug.Log("Random seed = " + numeroAleatorio);

        //JUGADOR 2

        if (pedidonumero2 == 1)
        {
            if (ocupado4 == false)
            {
                pedido4.text = "Lampara";
                ocupado4 = true;
                interno4 = "Caja Lampara";
                cantPedidos2++;
            }
            else if (ocupado3 == false)
            {
                pedido3.text = "Lampara";
                ocupado3 = true;
                interno3 = "Caja Lampara";
                cantPedidos2++;
            }
        }

        if (pedidonumero2 == 2)
        {
            if (ocupado4 == false)
            {
                pedido4.text = "Silla";
                ocupado4 = true;
                interno4 = "Caja Silla";
                cantPedidos2++;
            }
            else if (ocupado3 == false)
            {
                pedido3.text = "Silla";
                ocupado3 = true;
                interno3 = "Caja Silla";
                cantPedidos2++;
            }
        }

        if (pedidonumero2 == 3)
        {
            if (ocupado4 == false)
            {
                pedido4.text = "Mesa Noche";
                ocupado4 = true;
                interno4 = "Caja Mesa Noche";
                cantPedidos2++;
            }
            else if (ocupado3 == false)
            {
                pedido3.text = "Mesa Noche";
                ocupado3 = true;
                interno3 = "Caja Silla";
                cantPedidos2++;
            }
        }

        if (pedidonumero2 == 4)
        {
            if (ocupado4 == false)
            {
                pedido4.text = "Armario";
                ocupado4 = true;
                interno4 = "Caja Armario";
                cantPedidos2++;
            }
            else if (ocupado3 == false)
            {
                pedido3.text = "Armario";
                ocupado3 = true;
                interno3 = "Caja Armario";
                cantPedidos2++;
            }
        }

        if (pedidonumero2 == 5)
        {
            if (ocupado4 == false)
            {
                pedido4.text = "Sillon";
                ocupado4 = true;
                interno4 = "Caja Sillon";
                cantPedidos2++;
            }
            else if (ocupado3 == false)
            {
                pedido3.text = "Sillon";
                ocupado3 = true;
                interno3 = "Caja Sillon";
                cantPedidos2++;
            }
        }
    }

    public void p1chauPedido1(){
        pedido.text = null;
        ocupado1 = false;
        interno1 = null;
        cantPedidos1--;
    }

    public void p1chauPedido2(){
        pedido2.text = null;
        ocupado2 = false;
        interno2 = null;
        cantPedidos1--;
    }

    public void p2chauPedido3(){
        pedido3.text = null;
        ocupado3 = false;
        interno3 = null;
        cantPedidos2--;
    }

    public void p2chauPedido4(){
        pedido4.text = null;
        ocupado4 = false;
        interno4 = null;
        cantPedidos2--;
    }
 }

    
    

