using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    string nombre;
    string apellido1;
    string apellido2;
    int edad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void construirNombre(string nombre, string apellido1, string apellido2, int edad)
    {
      return Debug.Log("esta perosan se llama" +  nombre + apellido1+ apellido2 + " y tiene " + edad);  
    }
}
