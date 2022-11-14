using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombateJefe : MonoBehaviour
{
    [SerializeField] private int vidaJefe;
    [SerializeField] private int maximoVidaJefe;
    [SerializeField] private BarraVidaJefe barraDeVidaJefe;

    // Start is called before the first frame update
    void Start()
    {

        vidaJefe = maximoVidaJefe;
        barraDeVidaJefe.InicializarBarraDeVidaJefe(vidaJefe);

    }


    public void TomarDa�oJefe(int da�oJefe)
    {
        vidaJefe -= da�oJefe;
        barraDeVidaJefe.CambiarVidaActualJefe(vidaJefe);

        if (vidaJefe <= 0)
        {

            Destroy(gameObject);
        }
    }

}
