using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{
    [SerializeField] int exp;
    [SerializeField] int LVL = 50;
    // Start is called before the first frame update
    void Start()
    {
        calcularNivel();
    }

    // Update is called once per frame
    void calcularNivel()
    {
       int resultadoLVL = LVL + (9*exp/5);
        Debug.Log(resultadoLVL);
    }
}
