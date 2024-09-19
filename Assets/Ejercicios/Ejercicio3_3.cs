using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    [SerializeField] int numero;
    // Start is called before the first frame update
    void Start()
    {
        calcular();
    }

    // Update is called once per frame
    void calcular()
    {
        int doble = numero * 2;
        int triple = numero * 3;
        Debug.Log(doble);
        Debug.Log(triple);

    }
}
