using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/*
Nombre completo: Olivares Torres Victor Isaac
Asignatura: Programacion Orientada a Objetos
Nombre y número de ejercicio: Ejercicio 2
Descripción de lo que hace el script: Este Script se encarga de Heredar de los scripts de Vida, Score y Coins
para poder asignar datos de dichos scripts a la Interface.
*/

public class InterfacePlayer : MonoBehaviour
{
    //Se declaran variables de texto tipo Text Mesh Pro
    [Header("Interface Jugador")]
    public TMP_Text vidaTMP;
    public TMP_Text scoreTMP;
    public TMP_Text coinsTMP;

    //Se llaman a los Scripts correspondientes para la asignación de datos.
    ContadorVida vidas;
    ContadorScore score;
    ContadorCoins coins;

    // Start is called before the first frame update
    void Start()
    {
        vidas = GetComponent<ContadorVida>();
        score = GetComponent<ContadorScore>();
        coins = GetComponent<ContadorCoins>();

        //Se inicializa Corrutina creada mas abajo para comenzar a asignar datos
        StartCoroutine(AsignarDatos(0.1f));
    }

    // Update is called once per frame
    void Update()
    {
        //Actualiza los datos asignados a la interfacce
        vidaTMP.text = "VIDA: " + vidas.vidas;
        scoreTMP.text = "SCORE: " + score.score.ToString();
        coinsTMP.text = "COINS: " + coins.coins;
    }

    /*Metodo para crear una corrutina que asigne los valores correspondientes a sus textos
    en un tiempo de espera determinado por el float waitTime*/
    IEnumerator AsignarDatos(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        if (vidaTMP != null)
        {
            vidaTMP.text = "VIDA: " + vidas.vidas;
        }

        if (scoreTMP != null)
        {
            scoreTMP.text = "SCORE: " + score.score.ToString();
        }

        if (coinsTMP != null)
        {
            coinsTMP.text = "COINS: " + coins.coins;
        }
    }
}