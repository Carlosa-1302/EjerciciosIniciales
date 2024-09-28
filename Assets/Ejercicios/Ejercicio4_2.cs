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
        string nombreCompleto = construirNombre( "carlos", "ordoñez","juma",12);
        Debug.Log( nombreCompleto);
    }

    // Update is called once per frame
     string  construirNombre(string nombre, string apellido1, string apellido2, int edad)
    {
        string fraseNombre = ( "la persona se llama " + nombre+" " +apellido1+" " + apellido2 + " y tiene " + edad + " años");
        return fraseNombre;
    }
}
