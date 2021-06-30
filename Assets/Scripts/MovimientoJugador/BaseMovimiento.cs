using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMovimiento : MonoBehaviour
{
    public float velocidadMovimiento = 10;
    public float velocidadRotacion = 200;
    private Vector3 direccion;
    // Start is called before the first frame update
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
        bool moviendose = false;
        if (direccion.x != 0 || direccion.z != 0)
        {
            moviendose = true;
        }
        else
        {
            moviendose = false;
        }
        this.transform.Translate(direccion);

    }

    public void Rotacion()
    {
        float rotacionY = Input.GetAxis("Horizontal");
        Vector3 rotacion = new Vector3(0, rotacionY, 0);
        rotacion.y *= Time.deltaTime * velocidadRotacion;
        this.transform.Rotate(rotacion);
    }
}
