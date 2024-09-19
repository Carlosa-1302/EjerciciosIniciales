using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_4 : MonoBehaviour
{
    int vidas = 10;

    // Start is called before the first frame update
    void Start()
    {
        calcular();
        


    }

    // Update is called once per frame
    void calcular()
    {
        int incrementar = vidas + 67;
        int decrementar = vidas - 7;
        int cuadruplicar = vidas * 4;
        Debug.Log(incrementar);
        Debug.Log(decrementar);
        Debug.Log(cuadruplicar);
        
    }
}
