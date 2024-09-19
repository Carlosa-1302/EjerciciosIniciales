using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vidas = 10;
    float exp = 5.0f;
    char carac ;
    // Start is called before the first frame update
    void Start()
    {
        calcularSuma(1,5);
        calcularResta(5,1);

    }

    // Update is called once per frame
    void calcularSuma(int vidas, int exp)
    {
        int resultadoSuma = vidas + exp;
        Debug.Log(resultadoSuma);
    }
    void calcularResta(int vidas, int exp)
    {
        int resultadoResta = vidas - exp;
        Debug.Log(resultadoResta);
    }
}
