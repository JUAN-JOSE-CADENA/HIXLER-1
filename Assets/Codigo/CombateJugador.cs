using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CombateJugador : MonoBehaviour
{

    [SerializeField] private int vida;
    [SerializeField] private int maximoVida;
    [SerializeField] private BarraVida barraDeVida;

    [SerializeField] private AudioClip sonidoGolpe;

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
        ControladorSonidos.Instance.EjecutarSonido(sonidoGolpe);

        if (vida <= 0)
        {

            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

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
