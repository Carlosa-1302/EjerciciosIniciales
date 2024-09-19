using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    int vidasPlayer1 = 10;
    int vidasPlayer2 = 5;
    int vidasPlayer3 = 3;
    int vidasPlayer4 = 7;
    // Start is called before the first frame update
    void Start()
    {
        calcular();
    }

    // Update is called once per frame
    void calcular()
    {
        int valor1 = vidasPlayer2 + vidasPlayer3;
        int valor2 = vidasPlayer3 + vidasPlayer1;
        int valor3 = vidasPlayer1 + vidasPlayer4;
        int valor4 = vidasPlayer4 + vidasPlayer2;
        Debug.Log(valor1);
        Debug.Log(valor2);
        Debug.Log(valor3);
        Debug.Log(valor4);

    }
}
