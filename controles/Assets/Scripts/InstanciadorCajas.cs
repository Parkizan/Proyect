    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorCajas : MonoBehaviour
{
    public GameObject prefabCaja;
    int numeroAleatorio;
    int cantCajas;
    public GameObject[] spawners;
    bool hasSpawned = false;
    int lastNumber = 0;
    //public bool hasBeenPickedUp = false;

    void Start ()
    {
        StartCoroutine(SpawnCajas());
    }

    void Update()
    {
         cantCajas = GameObject.FindGameObjectsWithTag("cajita").Length;

         if (cantCajas <= 1){
         //if (hasBeenPickedUp){
         if (!hasSpawned){
             StartCoroutine(SpawnCajas());
             //hasBeenPickedUp = false;
         }
        // }
         }
    }

    IEnumerator SpawnCajas()
        {
                hasSpawned = true;
                yield return new WaitForSeconds(5);
                ClonarCajas();
                hasSpawned = false;
        }

    public void ClonarCajas()
    {
        Random.seed = (int)System.DateTime.Now.Ticks;
        // Random.Range(int floor, int ceiling);
        numeroAleatorio = Random.Range(1,8);
        //Debug.Log("Random seed = " + numeroAleatorio);

        if (lastNumber == numeroAleatorio)
        {
            numeroAleatorio++;
            Instantiate(prefabCaja, spawners[numeroAleatorio].transform.position, spawners[numeroAleatorio].transform.rotation);
            numeroAleatorio = lastNumber;
        }
        else
        {
            Instantiate(prefabCaja, spawners[numeroAleatorio].transform.position, spawners[numeroAleatorio].transform.rotation);
            numeroAleatorio = lastNumber;
        }

    }

}
