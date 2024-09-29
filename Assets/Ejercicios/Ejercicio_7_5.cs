using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_7_5 : MonoBehaviour
{
    [SerializeField] int valor;
    int numero = 1;
    // Start is called before the first frame update
    void Start()
    {
        while (numero <= valor)
        {
            Debug.Log("el numero actual es " + numero);
            numero++;
        }
        for (int numero = 1; numero <= valor; numero++)
        {
            Debug.Log("el numero actual es " + numero);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
