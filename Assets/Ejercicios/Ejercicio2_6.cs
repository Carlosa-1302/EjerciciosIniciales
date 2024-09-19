using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int puntuacion1 = 4;
    int puntuacion2 = 6;
    int puntuacion3 = 8;
    // Start is called before the first frame update
    void Start()
    {
        puntuacionesyMedia();
        
    }

    // Update is called once per frame
    void puntuacionesyMedia()
    {
        int puntuacionMedia = (puntuacion1 + puntuacion2 + puntuacion3) / 3;
        Debug.Log(puntuacion1);
        Debug.Log(puntuacion2);
        Debug.Log(puntuacion3);
        Debug.Log(puntuacionMedia);

    }
}
