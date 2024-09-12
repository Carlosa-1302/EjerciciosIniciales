using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_1 : MonoBehaviour
{
    string Carlos;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("¡Hola Mundo!");
        Debug.Log("Este es el primer videojuego de Carlos");
        Debug.Log("Estoy aprendiendo C#");

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ha pasado un frame");
    }
    //cuando es un void update se actualiza por cada frame el codigo repitiendo el mismo comando
    //pero en cambio el void start solo lo hace al comienzo (start)
}
