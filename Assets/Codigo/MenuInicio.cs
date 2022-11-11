using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuInicio : MonoBehaviour
{

    [SerializeField] private GameObject botonComoJugar;

    [SerializeField] private GameObject menuAjustes;

    public void Play()
    {
        //SceneManager.LoadScene(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ComoJugar()
    {

    }


    public void Ajustes()
    {

    }


    public void Salir()
    {
        Debug.Log("Cerrando Juego");
        Application.Quit();
    }
}
