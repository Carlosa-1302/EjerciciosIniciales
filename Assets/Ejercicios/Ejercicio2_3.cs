using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vidas = 10;
    float exp = 5.5f;
    // Start is called before the first frame update
    void Start()
    {
        CalcularProducto(vidas, exp);
        CalcularCociente(vidas, exp);
        CalcularResto(vidas, exp);
        CalcularDoble(vidas, exp);
        CalcularTriple(vidas, exp);

        
    }

    // Update is called once per frame
    void CalcularProducto(int vidas, float exp)
    {
        float elProducto = vidas * exp;
        Debug.Log(elProducto);
        
    }
    void CalcularCociente(int vidas, float exp)
    {
        float elCociente = vidas / exp;
        Debug.Log(elCociente);

    }
    void CalcularResto(int vidas, float exp)
    {
        float elResto = vidas % exp;
        Debug.Log(elResto);

    }
    void CalcularDoble(int vidas, float exp)
    {
        float elDoble = vidas ^ 2;
        Debug.Log(elDoble);

    }
    void CalcularTriple(int vidas, float exp)
    {
        float elTriple = exp * 3;
        Debug.Log(elTriple);
        

    }
}
