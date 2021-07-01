using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Olivares Torres Victor Isaac
Asignatura: Programacion Orientada a Objetos
Nombre y número de ejercicio: Ejercicio 3
Descripción de lo que hace el script: Este Script se encarga de instanciar los enemigos heredados de la BaseEnemigos
en un intervalo de 3 segundos, en una posición random, cuando se llega a 3 enemigos, la instanciación se detiene.
*/

public class ConstructorEnemigo : MonoBehaviour
{
    //Clase de donde se hereda el Arreglo que almacena a los enemigos
    BaseEnemigos generadorEnemigos;
    private void Awake()
    {
        generadorEnemigos = GetComponent<BaseEnemigos>();
}
    // Start is called before the first frame update
    void Start()
    {
        //Se inicializa corrutina coinstruida más abajo
        StartCoroutine(GeneradorEnemigos());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Para la creación de esta corrutina tomé referencias del canal de YouTube Profe Tic
    IEnumerator GeneradorEnemigos()
    {
        //variable que se encargará de registrar la cantidad de enemigos instanciados
        int contadorEnemigos = 0;

        //Esta línea condiciona la instanciación par que se detenga cuando el contadorEnemigos llegue a 3
        while (contadorEnemigos < 3)
        {
            //Variable utilizada para asignar un índice random en el Array de enemigos
            int indexRandom = Random.Range(0, 3);

            //Variable utilizada para asignar una posición random en X
            int numeroRandomX = Random.Range(-20, 20);

            //Variable utilizada para asignar una posición random en Y
            int numeroRandomZ = Random.Range(-20, 20);

            //Esta línea asigna la cantidad de segundos para el intervalo
            yield return new WaitForSeconds(3);

            /*Esta línea se encargará de instanciar los enemigos, tomando el valor random en X y Y anteriormente declaradas,
             de igual forma se instancia el enemigo del Array con un subindice Random*/
            Instantiate(generadorEnemigos.listaEnemigos[indexRandom], new Vector3(numeroRandomX, 3, numeroRandomZ), transform.rotation);

            //esta línea sumun 1 al contador enemigos
            contadorEnemigos++;

            //Esta línea imprime en consola el valor de contadorEnemigos, la utilicé para comprobar que el contador realizaba la suma
            Debug.Log(contadorEnemigos);
        }
    }
}
