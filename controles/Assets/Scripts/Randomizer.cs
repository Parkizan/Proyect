using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour
{
    

    void Start()
    {
        
    }

    
    void Update()
    {
        if (DeteccionCaja.num_Powerup > 0)
        {
            Debug.Log("funca");
            DeteccionCaja.num_Powerup = 0;

        }
    }
}
