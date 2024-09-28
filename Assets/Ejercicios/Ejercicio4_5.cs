using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_5 : MonoBehaviour
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






        float cantidadMoneda = convertir(areaCirculo, "dolar");
        Debug.Log(cantidadMoneda);
    }

    // Update is called once per frame
    public float calcularCirculo(float radio)
    {
        float resultadoCirculo = radio * radio * pi;
        return resultadoCirculo;

    }

    public float convertir(float areaCirculo , string moneda)
    {
        if (moneda == "euro")
        {
            float conversorEuro = areaCirculo * 1.1f;
            Debug.Log("el resultado del circulo " + areaCirculo + " son " + conversorEuro + " dolares");
            return conversorEuro;
        }
        else if (moneda == "dolar")
        {
            float conversorDolar = areaCirculo / 1.1f;
            Debug.Log("el resultado del circulo " + areaCirculo + " son " + conversorDolar + " euros");
            return conversorDolar;
        }
        return 0;


    }
}
