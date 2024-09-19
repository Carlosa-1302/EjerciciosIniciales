using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    [SerializeField] float radio;
    [SerializeField] float pi = 3.14f;
    [SerializeField] float Base;
    [SerializeField] float altura;
    [SerializeField] float lado;
    [SerializeField] float lado2;

    // Start is called before the first frame update
    void Start()
    {
        float areaCirculo = calcularCirculo(5);
        Debug.Log("el area del ciruclo es " + areaCirculo);

        float areaTriangulo = calcularTriangulo(6, 8);
        Debug.Log("el aread del triangulo es " + areaTriangulo);

        float areaCuadrado = calcularCuadrado(4, 8);
        Debug.Log("el area del cuadrado es " + areaCuadrado);
    }

    // Update is called once per frame
    float calcularCirculo(float radio)
    {
        float resultadoCirculo = radio*radio * pi;
        return resultadoCirculo;

    }
    float calcularTriangulo(float Base, float altura)
    {
        float resultadoTriangulo = (Base * altura) / 2;
        return resultadoTriangulo;
    }
    float calcularCuadrado(float lado, float lado2)
    {
        float resultadoCuadrado = lado * lado2;
        return resultadoCuadrado;
    }
}
