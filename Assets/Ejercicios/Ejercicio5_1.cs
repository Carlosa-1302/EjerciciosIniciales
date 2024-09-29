using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_1 : MonoBehaviour
{
    [SerializeField]int vida1, vida2 ;
    // Start is called before the first frame update
    void Start()
    {
        if (vida1 == vida2)
        {
            Debug.Log("empate");
        }
        else if (vida1 >= vida2)
        {
            Debug.Log("gana el jugador 1");
        }
        else if (vida2 >= vida1)
        {
            Debug.Log("gana el jugador 2");
        }
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }
}
