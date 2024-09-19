using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorPersonajes : MonoBehaviour
{
    int numero = 5;
    string texto = "Chalao";
    float num = 3.4f;
    [SerializeField] Personaje link; //puedes crear una clase como una fabrica y asignarle un nombre


    [SerializeField] Rigidbody rb; //ejemplo de convocar otra clase
    [SerializeField] GameObject mario;// tambien puedes convocar diferentes clases del unity */
    void Start()
    {
        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        //Con el intermediario se puede usar en el otro script y usarlo
        //link´s life
        link.Vida = 100;

       // mario.Vida = 50;

        //mario no se puede usar por que no es un "Personaje" es un "GameObject" ARRIBA

        //link´s velocity

        link.Nombre = "Link";
        link.Vida = 200;
        link.Danho = 150;
        link.Velocidad = 100;

        link.Mover(3, 0, -1);
       // mario.Mover(0, 9, 8);

        transform.Rotate(new Vector3(9, 8, 1));





    }
}
