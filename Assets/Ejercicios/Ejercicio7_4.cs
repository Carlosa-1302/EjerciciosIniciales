using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_4 : MonoBehaviour
{
    int numero = 1;
    // Start is called before the first frame update
    void Start()
    {
        for (int numero = 100; numero >= 100; numero--)
        {
            Debug.Log("el numero actual es " + numero);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
