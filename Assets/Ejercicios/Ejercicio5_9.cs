using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_9 : MonoBehaviour
{
    [SerializeField] int tipo;
    // Start is called before the first frame update
    void Start()
    {
        if (tipo == 1)
        {
            Debug.Log("a aparecido un enemigo de tipo 1 ha echo 350 de año con 650");
        }
        if (tipo == 2)
        {
            Debug.Log("a aparecido un enemigo de tipo 2 ha echo 300 de año con 550");
        }
        if (tipo == 3)
        {
            Debug.Log("a aparecido un enemigo de tipo 3 ha echo 300 de año con 500");
        }
        if (tipo == 4)
        {
            Debug.Log("a aparecido un enemigo de tipo 4 ha echo 310 de año con 460");
        }
        if (tipo == 5)
        {
            Debug.Log("a aparecido un enemigo de tipo 5 ha echo 280 de año con 490");
        }
        if (tipo == 6)
        {
            Debug.Log("a aparecido un enemigo de tipo 6 ha echo 360 de año con 520");
        }
    }
}
