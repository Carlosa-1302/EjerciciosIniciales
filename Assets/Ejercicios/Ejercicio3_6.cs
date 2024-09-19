using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField] float kmh;
    // Start is called before the first frame update
    void Start()
    {
        calcularKMaM();
    }

    // Update is called once per frame
    void calcularKMaM()
    {
        float resultadoMS = kmh / 3.6f;
        Debug.Log("va a " + resultadoMS + "m/s");

    }
}
