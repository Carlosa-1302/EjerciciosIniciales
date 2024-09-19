using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    float Pi = 3.14f;
    [SerializeField] float radio;
    // Start is called before the first frame update
    void Start()
    {
        calcularLongitud();
        areaCircunferencia();
    }

    // Update is called once per frame
    void calcularLongitud()
    {
        float resultadoLongitud = 2 * Pi * radio;
        Debug.Log("la longuitud es " + resultadoLongitud);
    }
    void areaCircunferencia()
    {
        float recultadoArea = (Pi * radio) * 2;
        Debug.Log("el area es " + recultadoArea);
    }
}
