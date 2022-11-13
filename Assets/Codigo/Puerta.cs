using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puerta : MonoBehaviour
{
    [SerializeField] private int cantidadEnemigos;

    [SerializeField] private int enemigosEliminados;

    private Animator animator;


    private void Start()
    {
        animator = GetComponent<Animator>();
        //cantidadEnemigos = GameObject.FindGameObjectsWithTag("Enemigo").Length;
    }

    
    private void ActivarPuerta()
    {
        animator.SetTrigger("Activar");
    }


    //public void EnemigoEliminado()
    //{
    //    enemigosEliminados += 1;

    //    if(enemigosEliminados == cantidadEnemigos)
    //    {
    //        ActivarPuerta();
    //    }
    //}


    private void OnTriggerEnter2D(Collider2D other)
    {
        //if(other.CompareTag("Player") && enemigosEliminados == cantidadEnemigos)
        //{
        //    //CambiarEscena
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //}
        ActivarPuerta();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
