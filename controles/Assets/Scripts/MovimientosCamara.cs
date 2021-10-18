using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientosCamara : MonoBehaviour
{
    public List<Transform> targets; //lista de targets
 
    public Vector3 offset; //spawn de la camara
    public float smoothTime = .5f; //suavidad del movimiento de la camara
 
    public float minZoom = 70f; //Minimo zoom que puede tomar la camara al jugador
    public float maxZoom = 40f; //Maximo zoom que tomar la camara al jugador
    public float zoomLimiter = 40f; //Zoom entre los objetivos (jugadores)
 
    private Vector3 velocity;
    private Camera cam; //donde se almacena la camara
 
 
    private void Start()
    {
 
        cam = GetComponent<Camera>();  //identificacion de la camara
 
    }
 
    private void LateUpdate() //update despues del update
    {
 
        if (targets.Count == 0) //si no hay ningun objetivo, no hacer nada
            return;
 
 
        move();
        zoom();
 
    }
 
    void zoom() //funcion del zoom
    {
 
        float newZoom = Mathf.Lerp(maxZoom, minZoom, getGreatestDistance() / zoomLimiter); //encuentra un valor entre al zoom minimo y maximo
        cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, newZoom, Time.deltaTime); // se lo aplica a la camara en un determinano numero de segundos para que quede "suave"
 
 
    }
 
 
    void move() //funcion de mover la camara
    {
 
        Vector3 centerPoint = getCenterPoint();
        Vector3 newPosition = centerPoint + offset;
        transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref velocity, smoothTime);
 
    }
 
    float getGreatestDistance() //Saca la distancia entre los objetivos mas lejanos
    {
 
        var bounds = new Bounds(targets[0].position, Vector3.zero); //crea un grupo de objetos (bounds)
        for (int i = 0; i < targets.Count; i++)
        {
 
            bounds.Encapsulate(targets[i].position); //saca la posicion central del bound
 
 
        }
 
        return bounds.size.x;
 
    }
 
 
    Vector3 getCenterPoint() //saca el punto medio de la distancia de los objetivos
    {
 
        if (targets.Count == 1) //si es 1, es la posicion de ese
        {
 
            return targets[0].position;
 
 
        }
 
        var bounds = new Bounds(targets[0].position, Vector3.zero);
        for (int i = 0; i < targets.Count; i++)
        {
 
 
            bounds.Encapsulate(targets[i].position); //sino, crea un bound y saca su punto central
 
        }
 
        return bounds.center;
 
 
    }
}
