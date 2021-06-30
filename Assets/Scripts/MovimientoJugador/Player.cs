using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Olivares Torres Victor Isaac
Asignatura: Programacion Orientada a Objetos
Nombre y n�mero de ejercicio: Ejercicio 1
Descripci�n de los que hace el script: Este Script se encarga de heredar los m�todos creados en Base de Movimiento para
ser ejecutados por el jugador en Pantalla.
*/

public class Player : MonoBehaviour
{
    //Se declara La clase donde se van a heredar los metodos para el movimiento del jugador
    BaseMovimiento movement;
    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<BaseMovimiento>();
    }

    // Update is called once per frame
    void Update()
    {
        //Se inicializan los m�todos del script de donde se hereda el movimiento
        movement.Movimiento();
        movement.Rotacion();
        movement.Salto();
    }
}
