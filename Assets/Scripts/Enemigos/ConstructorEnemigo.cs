using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Olivares Torres Victor Isaac
Asignatura: Programacion Orientada a Objetos
Nombre y n�mero de ejercicio: Ejercicio 3
Descripci�n de lo que hace el script: Este Script se encarga de instanciar los enemigos heredados de la BaseEnemigos
en un intervalo de 3 segundos, en una posici�n random, cuando se llega a 3 enemigos, la instanciaci�n se detiene.
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
        //Se inicializa corrutina coinstruida m�s abajo
        StartCoroutine(GeneradorEnemigos());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Para la creaci�n de esta corrutina tom� referencias del canal de YouTube Profe Tic
    IEnumerator GeneradorEnemigos()
    {
        //variable que se encargar� de registrar la cantidad de enemigos instanciados
        int contadorEnemigos = 0;

        //Esta l�nea condiciona la instanciaci�n par que se detenga cuando el contadorEnemigos llegue a 3
        while (contadorEnemigos < 3)
        {
            //Variable utilizada para asignar un �ndice random en el Array de enemigos
            int indexRandom = Random.Range(0, 3);

            //Variable utilizada para asignar una posici�n random en X
            int numeroRandomX = Random.Range(-20, 20);

            //Variable utilizada para asignar una posici�n random en Y
            int numeroRandomZ = Random.Range(-20, 20);

            //Esta l�nea asigna la cantidad de segundos para el intervalo
            yield return new WaitForSeconds(3);

            /*Esta l�nea se encargar� de instanciar los enemigos, tomando el valor random en X y Y anteriormente declaradas,
             de igual forma se instancia el enemigo del Array con un subindice Random*/
            Instantiate(generadorEnemigos.listaEnemigos[indexRandom], new Vector3(numeroRandomX, 3, numeroRandomZ), transform.rotation);

            //esta l�nea sumun 1 al contador enemigos
            contadorEnemigos++;

            //Esta l�nea imprime en consola el valor de contadorEnemigos, la utilic� para comprobar que el contador realizaba la suma
            Debug.Log(contadorEnemigos);
        }
    }
}
