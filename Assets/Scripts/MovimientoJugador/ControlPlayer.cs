using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    BaseMovimiento movement;
    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<BaseMovimiento>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.Movimiento();
        movement.Rotacion();
    }
}
