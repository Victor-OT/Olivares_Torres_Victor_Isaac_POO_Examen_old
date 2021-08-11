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
    //Aqui se declaran los datos a utilizar
    Animator animPlayer;
    public float velocidadMovimiento;
    public float velocidadRotacion;
    private Vector3 direccion;
    public bool standAttack;

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
        //Esta Linea nos sirve para registrar los datos de entrada de teclado
        float movimientoVertical = Input.GetAxis("Vertical");
        float movimientoHorizontal = Input.GetAxis("Horizontal");

        //Aqui se declara e inicializa un vector para utilizar en el traslado
        direccion = new Vector3(movimientoHorizontal, 0, movimientoVertical);

        //se realiza la operación para generar el movimiento
        direccion *= Time.deltaTime;
        direccion.Normalize();

        // Un bool que devuelve true or false dependiendo del valor en el eje Z del vector anteriormente declarado
        //bool moviendose = direccion.z != 0 ? true : false;

        //Se ejecuta la orden de trasladar al jugador
        this.transform.Translate(direccion*velocidadMovimiento);

        //Cuando el bool anteriormente declarado retorna un valor true, se ejecuta animación de correr
        animPlayer.SetFloat("Speed", direccion.z);
        animPlayer.SetFloat("SpeedLateral", direccion.x);
        //animPlayer.SetBool("run", moviendose);
    }

    public void StandingAttack(bool a)
    {
        animPlayer.SetBool("StandAttack", a);
    }

    public void Attack()
    {
        animPlayer.SetTrigger("Attack");
    }

    public void Ataques(int i)
    {
        animPlayer.SetInteger("Ataques", i);
    }

    public void Rotacion()
    {
        //Esta Linea nos sirve para registrar los datos de entrada de teclado
        //float rotacionY = Input.GetAxis("Horizontal");

        //Aqui se declara e inicializa un vector para utilizar en la rotacion
        //Vector3 rotacion = new Vector3(0, rotacionY, 0);

        //se realiza la operación para generar la rotacion
        //rotacion.y *= Time.deltaTime * velocidadRotacion;

        //Se ejecuta la orden de rotar al jugador
        //this.transform.Rotate(rotacion);
    }

    public void Salto()
    {
        /*Se ejecuta animación de Salto al dar espacio como entrada de teclado, no requiere ningún valor pues la animación se encarga
        del traslado en X y Y*/
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animPlayer.SetTrigger("jump");
        }
    }
}
