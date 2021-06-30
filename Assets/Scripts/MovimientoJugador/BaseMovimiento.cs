using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Olivares Torres Victor Isaac
Asignatura: Programacion Orientada a Objetos
Nombre y número de ejercicio: Ejercicio 1
Descripción de los que hace el script: Este Script se encarga de recopilar los valores necesarios y realizar las operaciones
para generar movimiento de un personaje.
*/

public class BaseMovimiento : MonoBehaviour
{
    Animator animPlayer;
    public float velocidadMovimiento;
    public float velocidadRotacion;
    private Vector3 direccion;
    // Start is called before the first frame update
    private void Awake()
    {
        animPlayer = GetComponent<Animator>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Movimiento()
    {
        float movimientoHorizontal = Input.GetAxis("Vertical");
        direccion = new Vector3(0, 0, movimientoHorizontal);
        direccion *= Time.deltaTime * velocidadMovimiento;
        bool moviendose = direccion.z != 0 ? true : false;
        this.transform.Translate(direccion);
        animPlayer.SetBool("run", moviendose);
    }

    public void Rotacion()
    {
        float rotacionY = Input.GetAxis("Horizontal");
        Vector3 rotacion = new Vector3(0, rotacionY, 0);
        rotacion.y *= Time.deltaTime * velocidadRotacion;
        this.transform.Rotate(rotacion);
    }

    public void Salto()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animPlayer.SetTrigger("jump");
        }
    }
}
