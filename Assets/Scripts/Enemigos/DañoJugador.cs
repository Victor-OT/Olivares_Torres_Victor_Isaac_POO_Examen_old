using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Olivares Torres Victor Isaac
Asignatura: Programacion Orientada a Objetos
Nombre y número de ejercicio: Ejercicio 4 y 5
Descripción de lo que hace el script: Este Script se encarga de tener la funcion de causar
daño al jugador
*/

public class DañoJugador : MonoBehaviour
{
    //Variable que restara valor al contador de vidas
    float daño = 1;

    int incrementoScore = 1;


    ContadorVida registroVida;
    ContadorCoins registroCoins;
    // Start is called before the first frame update
    void Start()
    {
        registroVida = GetComponent<ContadorVida>();
        registroCoins = GetComponent<ContadorCoins>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Daño()
    {
        //Realiza la operacion de restar vida
        registroVida.vidas -= daño;
        Debug.Log(registroVida.vidas);

        //Esta condicion destruye l player cuando su contador de vidas llega a 0
        if (registroVida.vidas <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    //Metodo que suma coins al colisionar con objeto coin
    public void SumaCoins()
    {
        registroCoins.coins += incrementoScore;
    }
}
