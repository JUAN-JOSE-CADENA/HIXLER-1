using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jefe : MonoBehaviour
{
    [SerializeField] private float vida;

    [SerializeField] private BarraVidaJefe barraDeVida;

    [SerializeField] private GameObject efectoMuerte;

    // Start is called before the first frame update
    void Start()
    {

        //vidaJefe = maximoVidaJefe;
        barraDeVida.InicializarBarraDeVida(vida);

    }


    public void TomarDaño(float daño)
    {
        vida -= daño;

        barraDeVida.CambiarVidaActual(vida);

        if (vida <= 0)
        {
            //Destroy(gameObject);
            Muerte();
        }
    }

    private void Muerte()
    {
        Instantiate(efectoMuerte, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
