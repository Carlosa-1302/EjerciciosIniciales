using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{
    [SerializeField] int numero;
    [SerializeField] int num;
    // Start is called before the first frame update
    void Start()
    {
        while (numero <= num)
        {
            Debug.Log("el numero actual es " + numero);
            numero++;
        }
        
        for (; numero >= num; numero++)
        {
            Debug.Log("el numero actual es " + numero);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
