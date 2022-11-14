using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVidaJefe : MonoBehaviour
{
    private Slider slider;
    //private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame

    public void CambiarVidaMaximaJefe(int vidaMaximaJefe)
    {
        slider.maxValue = vidaMaximaJefe;
    }


    public void CambiarVidaActualJefe(int cantidadVidaJefe)
    {
        slider.value = cantidadVidaJefe;
        //animator.SetTrigger("Golpe");
    }


    public void InicializarBarraDeVidaJefe(int cantidadVidaJefe)
    {
        CambiarVidaMaximaJefe(cantidadVidaJefe);
        CambiarVidaActualJefe(cantidadVidaJefe);
    }
}
