using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_7 : MonoBehaviour
{
    int velocidad;
    [SerializeField]int numero1, numero2, numero3;
    // Start is called before the first frame update
    void Start()
    {
        if( numero1 > numero2 && numero1 > numero3 )
        {
            Debug.Log("atacara primero el jugador numero 1");

        }
        else if(numero2 > numero1 && numero2 > numero3)
        {
            Debug.Log("atacara primero el jugador numero 2");
        }
        else if (numero3 > numero1 && numero3 > numero2)
        {
            Debug.Log("atacara primero el jugador numero 3");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
