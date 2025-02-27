using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{

    private Slider slider;
    //private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame

    public void CambiarVidaMaxima(int vidaMaxima)
    {
        slider.maxValue = vidaMaxima;
    }


    public void CambiarVidaActual(int cantidadVida)
    {
        slider.value = cantidadVida;
        //animator.SetTrigger("Golpe");
    }


    public void InicializarBarraDeVida(int cantidadVida)
    {
        CambiarVidaMaxima(cantidadVida);
        CambiarVidaActual(cantidadVida);
    }
}
