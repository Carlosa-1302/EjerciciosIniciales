using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    [SerializeField] float Base;
    [SerializeField] float Altura;

    // Start is called before the first frame update
    void Start()
    {
        calcularArea();
    }

    // Update is called once per frame
    void calcularArea()
    {
        float resultadoArea = (Base * Altura) / 2f;
        Debug.Log("el area del triangulo es " + resultadoArea);
    }
}
