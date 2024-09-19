using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    //COMO se define mi personaje
    //Propiedades o atributos
    private string nombre;
    private float vida;
    private float danho;
    private float velocidad; 
    //hay que poner en "private" para que se pueda usar pero que nadie lo vea


    //con alt IZD + ENTER tienes que encapsularlo pero seguir usandolo, para que pueda ser un Intermediario
    //ATENTO que ahora la INICIAL esta en MAYUSCULA
    public float Vida { get => vida; set => vida = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public float Danho { get => danho; set => danho = value; }
    public float Velocidad { get => velocidad; set => velocidad = value; }


    //QUÉ puede hacer mi personaje
    //Funcionalidades



    //hay que convertir las funcionalidades en "public" Void por que no hay forma de hacer Intermediario

    public void Mover(float x, float y, float z)
    {

    }
    public void Atacar()
    {

    }
    public void Saltar()
    {

    }

}
