using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{
    float medida ;
    string unidad = "km" + "m";
    // Start is called before the first frame update
    void Start()
    {
        float resultado = conversorVelocidad(10, "km");
        Debug.Log(resultado);
    }

    // Update is called once per frame
    float conversorVelocidad(float medida,string unidad)
    {
        if (unidad == "km") 
        {
            float resultadoM = medida * 1000;
            Debug.Log(medida + "km es " + resultadoM + "ms");
            return resultadoM;
        }
        if (unidad == "m")
        {
            float resultadoKM = medida / 1000;
            Debug.Log(medida + "m es" + resultadoKM + "ms");
            return resultadoKM;
        }
        return 0;




    }
}
