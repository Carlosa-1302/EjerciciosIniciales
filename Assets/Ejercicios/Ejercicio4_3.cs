using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{

    float cantidad;
    string moneda = "dolar" + "euro";
    // Start is called before the first frame update
    void Start()
    {
        float cantidadMoneda = convertir(5.0f, "dolar");
        Debug.Log(cantidadMoneda);
    }

    // Update is called once per frame
    float convertir (float cantidad,string moneda)
    {
        if (moneda == "euro")
        {
            float conversorEuro = cantidad * 1.1f;
            Debug.Log(cantidad + " son " + conversorEuro + " dolares");
            return conversorEuro;
        }
        else if (moneda == "dolar")
        {
            float conversorDolar = cantidad / 1.1f;
            Debug.Log(cantidad + " son " + conversorDolar + " euros");
            return conversorDolar;
        }
        return 0;
        
        
    }
}
