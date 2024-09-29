using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_6 : MonoBehaviour
{
    [SerializeField] int nivel;
    // Start is called before the first frame update
    void Start()
    {
        if (nivel % 10 == 0)
        {
            Debug.Log("el pokemon a subido al nivel " + nivel + " nuevo ataque desbloqueado");
        }
        else
        {
            Debug.Log("el pokemon ha subido de nivel");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
