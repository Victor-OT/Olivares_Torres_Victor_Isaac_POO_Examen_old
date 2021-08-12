using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarZona : MonoBehaviour
{
    public MoveIA enemigo;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enemigo.estadoActual = EstadosAI.AtacaDistancia;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enemigo.estadoActual = EstadosAI.Persecucion;
        }
    }
}
