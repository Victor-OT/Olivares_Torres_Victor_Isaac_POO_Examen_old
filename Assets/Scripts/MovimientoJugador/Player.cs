 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Olivares Torres Victor Isaac
Asignatura: Programacion Orientada a Objetos
Nombre y número de ejercicio: Ejercicio 1
Descripción de los que hace el script: Este Script se encarga de heredar los métodos creados en Base de Movimiento para
ser ejecutados por el jugador en Pantalla.
*/

public class Player : MonoBehaviour
{
    public bool standAttack;
    public int indice;
    public GameObject pistola;
    //Se declara La clase donde se van a heredar los metodos para el movimiento del jugador
    BaseMovimiento movement;
    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<BaseMovimiento>();
        pistola.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Se inicializan los métodos del script de donde se hereda el movimiento
        movement.Movimiento();
        movement.LookAtAim();
        movement.Salto();
        

        if (Input.GetMouseButtonDown(1))
        {
            indice = 0;
        }

        if (Input.GetMouseButtonDown(0))
        {
            indice++;
            if (indice > 3)
            {
                indice = 0;
            }
        }

        movement.StandingAttack(standAttack);
        movement.Ataques(indice);
        switch (indice)
        {
            case 1:
                pistola.SetActive(true);
                break;
            case 2:
                pistola.SetActive(false);
                break;
            case 3:
                pistola.SetActive(false);
                break;
            default: pistola.SetActive(false);
                break;
        }

    }
}
