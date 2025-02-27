using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ControladorEnemigos : MonoBehaviour
{
    private float minX, maxX, minY, masxY;

    [SerializeField] private Transform[] puntos;

    [SerializeField] private GameObject[] enemigos;

    [SerializeField] private float tiempoEnemigos;

    private float tiempoSiguienteEnemigo;


    private void Start()
    {
        maxX = puntos.Max(punto => punto.position.x);
        minX = puntos.Min(punto => punto.position.x);
        masxY = puntos.Max(punto => punto.position.y);
        minY = puntos.Min(punto => punto.position.y);
    }


    private void Update()
    {
        tiempoSiguienteEnemigo += Time.deltaTime;

        if(tiempoSiguienteEnemigo >= tiempoEnemigos)
        {
            tiempoSiguienteEnemigo = 0;

            //Crear Enemigo
            CrearEnemigo();
        }
    }


    private void CrearEnemigo()
    {
        int numeroEnemigo = Random.Range(0, enemigos.Length);

        Vector2 posicionAleatoria = new Vector2(Random.Range(minX, maxX), Random.Range(minY, masxY));

        Instantiate(enemigos[numeroEnemigo], posicionAleatoria, Quaternion.identity);
    }
}
 