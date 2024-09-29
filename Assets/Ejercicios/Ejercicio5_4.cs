using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{

    [SerializeField]int numero1, numero2;
    // Start is called before the first frame update
    void Start()
    {
        if (numero2 != 0)
        {
            int calculardivision = numero1 / numero2;
            Debug.Log("el resultado es " + calculardivision);

        }
        else 
        {
            Debug.Log("el divisor no debe ser 0");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
