using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_8 : MonoBehaviour
{
    [SerializeField]int hora, minutos, segundos;
    // Start is called before the first frame update
    void Start()
    {
        if (hora <= 24 && minutos <= 60 && segundos <= 60)
        {
            Debug.Log("son las " +  hora + ":" + minutos + ":" + segundos);
        }
        else
        {
            Debug.Log("el formato es incorrecto");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
