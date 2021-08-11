using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIA : MonoBehaviour
{
    public Transform target;
    public float velocidad;
    public Animator animEnemigo;
    public float distanciaExacta;
    // Start is called before the first frame update
    void Start()
    {
        animEnemigo = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = target.position - transform.position;
        Debug.Log(direccion.sqrMagnitude);
        transform.LookAt(target);
        if (direccion.sqrMagnitude > distanciaExacta)
        {
            Move(direccion);
            AnimacionBool("run", true);
        }
        else if (direccion.magnitude < distanciaExacta)
        {
            PlayAnimation("Quad Punch");
        }
        else
        {

            AnimacionBool("run", false);
        }
    }

    public void Move(Vector3 direccion)
    {
        this.transform.Translate(direccion.normalized * velocidad * Time.deltaTime, Space.World);
    }

    private void AnimacionBool(string nombreAnimacion, bool valor)
    {
        animEnemigo.SetBool(nombreAnimacion, valor);
    }

    private void PlayAnimation (string nombreClip)
    {
        animEnemigo.Play(nombreClip);
    }
}
