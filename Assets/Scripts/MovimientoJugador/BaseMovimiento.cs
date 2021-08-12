using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Olivares Torres Victor Isaac
Asignatura: Programacion Orientada a Objetos
Nombre y n�mero de ejercicio: Ejercicio 1
Descripci�n de los que hace el script: Este Script se encarga de recopilar los valores necesarios y realizar las operaciones
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

        //se realiza la operaci�n para generar el movimiento
        direccion *= Time.deltaTime;
        direccion.Normalize();

        // Un bool que devuelve true or false dependiendo del valor en el eje Z del vector anteriormente declarado
        //bool moviendose = direccion.z != 0 ? true : false;

        //Se ejecuta la orden de trasladar al jugador
        this.transform.Translate(direccion*velocidadMovimiento);

        //Cuando el bool anteriormente declarado retorna un valor true, se ejecuta animaci�n de correr
        animPlayer.SetFloat("Speed", direccion.z);
        animPlayer.SetFloat("SpeedLateral", direccion.x);
        //animPlayer.SetBool("run", moviendose);
    }

    public void LookAtAim()
    {
        float h_Rotacion = Input.GetAxisRaw("Mouse X");
        Vector3 rotacion_H = new Vector3(0, h_Rotacion, 0);
        rotacion_H *= Time.deltaTime * velocidadRotacion;
        this.transform.Rotate(rotacion_H);
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
    
    public void Salto()
    {
        /*Se ejecuta animaci�n de Salto al dar espacio como entrada de teclado, no requiere ning�n valor pues la animaci�n se encarga
        del traslado en X y Y*/
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animPlayer.SetTrigger("jump");
        }
    }
}
