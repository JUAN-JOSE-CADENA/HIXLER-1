using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombateJugador : MonoBehaviour
{

    [SerializeField] private int vida;
    [SerializeField] private int maximoVida;
    [SerializeField] private BarraVida barraDeVida;

    // Start is called before the first frame update
    void Start()
    {

        vida = maximoVida;
        barraDeVida.InicializarBarraDeVida(vida);

    }


    public void TomarDaño(int daño)
    {
        vida -= daño;
        barraDeVida.CambiarVidaActual(vida);

        if (vida <= 0)
        {

            Destroy(gameObject);
        }
    }


    public void Curar(int curacion)
    {
        if ((vida + curacion) > maximoVida)
        {
            vida = maximoVida;
        }

        else
        {
            vida += curacion;
        }
    }

}
