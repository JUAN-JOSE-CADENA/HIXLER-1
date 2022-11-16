using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoSucubus : MonoBehaviour
{
    [SerializeField] private float vida;

    [SerializeField] private GameObject efectoMuerte;

    [SerializeField] private AudioClip sonidoMuerte;


    public void TomarDa�o(float da�o)
    {
        vida -= da�o;

        if (vida <= 0)
        {
            Muerte();
        }
    }


    private void Muerte()
    {
        Instantiate(efectoMuerte, transform.position, Quaternion.identity);
        ControladorSonidos.Instance.EjecutarSonido(sonidoMuerte);
        Destroy(gameObject);
    }
}
