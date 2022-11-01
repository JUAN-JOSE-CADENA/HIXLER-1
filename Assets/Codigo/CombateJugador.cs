using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombateJugador : MonoBehaviour
{

    [SerializeField] private float vida;
    [SerializeField] private float maximoVida;
    [SerializeField] private BarraVida barraDeVida;

    private PlayerController movimientoJugador;
    [SerializeField] private float tiempoPerdidaControl;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        movimientoJugador = GetComponent<PlayerController>();
        animator = GetComponent<Animator>();

        vida = maximoVida;
        barraDeVida.InicializarBarraDeVida(vida);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TomarDa�o(float da�o)
    {
        vida -= da�o;
        barraDeVida.CambiarVidaActual(vida);

        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void TomarDa�o(float da�o, Vector2 posicion)
    {
        vida -= da�o;
        animator.SetTrigger("Golpe");
        StartCoroutine(PerderControl());

        //perder control
        movimientoJugador.Rebote(posicion);
    }

    private IEnumerator PerderControl()
    {
        movimientoJugador.sePuedeMover = false;
        yield return new WaitForSeconds(tiempoPerdidaControl);
        movimientoJugador.sePuedeMover = true;
    }

    public void Curar(float curacion)
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
