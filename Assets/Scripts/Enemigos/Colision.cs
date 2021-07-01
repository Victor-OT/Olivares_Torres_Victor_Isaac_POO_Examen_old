using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Olivares Torres Victor Isaac
Asignatura: Programacion Orientada a Objetos
Nombre y número de ejercicio: Ejercicio 4
Descripción de lo que hace el script: Este script registra las colisiones que pide como
parametro el nombre del objeto colisionado, además de invocar el metodo de causar daño heredado
del script DañoJugador.
*/

public class Colision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*este metodo registra la colision del jugador con el enemigo, además de
     causar daño al jugador*/
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Enemy2")
        {
            this.gameObject.GetComponent<DañoJugador>().Daño();
            Debug.Log("Me estás tocando");
        }
    }
}
