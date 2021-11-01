using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Entrega : MonoBehaviour
{
    public Text[] pedidos;


    private void OnCollisionEnter(Collision other)
    {
        if(other.transform.parent == null && (other.gameObject.tag == "Caja Armario" || other.gameObject.tag == "Caja Silla" || other.gameObject.tag == "Caja Lampara" || other.gameObject.tag == "Caja Mesa Noche" || other.gameObject.tag == "Caja Sillon"))
        {
            Identificadorcaja ic = other.gameObject.GetComponent<Identificadorcaja>();
            GameManager gm = FindObjectOfType<GameManager>();
            SistemaPedidos sp = gm.GetComponent<SistemaPedidos>();
            SistemaPuntos pts = gm.GetComponent<SistemaPuntos>();

            if(ic.LastParent == 1)
            {
                if(other.gameObject.tag == sp.interno1)
                {
                    sp.p1chauPedido1();
                    pts.puntos1 = (pts.puntos1 + 10);
                    Destroy(other.gameObject);
                }

                if(other.gameObject.tag == sp.interno2)
                {
                    sp.p1chauPedido2();
                    pts.puntos1 = (pts.puntos1 + 10);
                    Destroy(other.gameObject);
                }
            }

            if(ic.LastParent == 2)
            {
                if (other.gameObject.tag == sp.interno3)
                {
                    sp.p2chauPedido3();
                    pts.puntos2 = (pts.puntos2 + 10);
                    Destroy(other.gameObject);
                }

                if (other.gameObject.tag == sp.interno4)
                {
                    sp.p2chauPedido4();
                    pts.puntos2 = (pts.puntos2 + 10);
                    Destroy(other.gameObject);
                }
            }
        }
    }
}
