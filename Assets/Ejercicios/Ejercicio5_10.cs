using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_10 : MonoBehaviour
{
    [SerializeField] int temperatura;
    // Start is called before the first frame update
    void Start()
    {
        if (temperatura <= 10 )
        {
            Debug.Log("el clima es frio");
        }
         if   ( temperatura  >= 10 && temperatura <= 20 )
        {
            Debug.Log("el clima esta nublado");
        }
         if (temperatura >= 20 &&  temperatura <= 30)
        {
            Debug.Log("el clima esta caluroso");
        }
        if (temperatura > 30)
        {
            Debug.Log("el clima esta tropical");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
