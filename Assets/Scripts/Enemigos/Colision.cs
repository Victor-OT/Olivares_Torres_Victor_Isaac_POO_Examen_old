using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Olivares Torres Victor Isaac
Asignatura: Programacion Orientada a Objetos
Nombre y n�mero de ejercicio: Ejercicio 4
Descripci�n de lo que hace el script: Este script registra las colisiones que pide como
parametro el nombre del objeto colisionado, adem�s de invocar el metodo de causar da�o heredado
del script Da�oJugador.
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

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            collision.gameObject.GetComponent<Da�oJugador>().Da�o();
            Debug.Log("Me est�s tocando");
        }
    }
}
