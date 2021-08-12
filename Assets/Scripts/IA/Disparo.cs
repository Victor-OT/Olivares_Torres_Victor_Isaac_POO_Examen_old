using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public Transform puntaArma;
    public Rigidbody bala;

    public void Disparar()
    {
        Rigidbody rbPos = Instantiate(bala) as Rigidbody;
        rbPos.transform.position = puntaArma.position;
        rbPos.AddForce(puntaArma.forward * 5000);
    }                               
}
