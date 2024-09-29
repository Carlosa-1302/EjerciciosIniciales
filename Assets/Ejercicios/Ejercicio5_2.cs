using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
    [SerializeField]int numero1, numero2;
    // Start is called before the first frame update
    void Start()
    {
        if (numero1 <= 3 && numero2 <= 3)
        {
            Debug.Log("el numero " + numero1 + " es igual o menor a 3" + "y el numero " + numero2 + " es igual o menor a 3");
        }
        else if (numero1 > 3 && numero2 > 3)
        {
            Debug.Log("el numero " + numero1 + " es igual o mayor a 3" + " y el numero " + numero2 + " es igual o mayor a 3");
        }
        else 
        {
            Debug.Log("un numero es mayor a 3 y el otro menor o igual a 3");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
