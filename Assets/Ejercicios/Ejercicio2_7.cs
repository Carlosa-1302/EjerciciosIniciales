using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{
    int oro = 7;
    int segundos;

    // Start is called before the first frame update
    void Start()
    {
        calcularFarmeo(oro, 14400);
    }

    // Update is called once per frame
    void calcularFarmeo(int oro, int segundos)
    {
        int resultadoFarmeo = oro * segundos;
        Debug.Log(resultadoFarmeo);

    }
}
