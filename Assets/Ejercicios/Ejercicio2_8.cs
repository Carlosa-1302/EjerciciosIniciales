using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    float vida = 120;

    float vidaActual;
    // Start is called before the first frame update
    void Start()
    {
        vidaActual = vida;
        Debug.Log(vidaActual);
    }

    // Update is called once per frame
    void turnos(int vida)
    {
        float cantidadARestar = vida * 0.03f;
        
        cantidadARestar = vida * 0.06f;
        cantidadARestar = vida * 0.09f;
        cantidadARestar = vida * 0.12f;
        cantidadARestar = vida * 0.15f;
    }
}
