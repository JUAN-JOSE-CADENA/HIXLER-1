using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoJugador : MonoBehaviour
{
    [SerializeField] private Transform controladorDisparo;

    [SerializeField] private float rango;

    [SerializeField] private GameObject efectoImpacto;

    [SerializeField] private LineRenderer disparo;

    [SerializeField] private float tiempoDisparo;


    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Disparar();
        }
    }


    private void Disparar()
    {
        RaycastHit2D raycastHit2D = Physics2D.Raycast(controladorDisparo.position, controladorDisparo.right, rango);

        if(raycastHit2D)
        {
            if (raycastHit2D.transform.CompareTag("Enemigo"))
            {
                raycastHit2D.transform.GetComponent<Enemigo>().TomarDaño(20);
                Instantiate(efectoImpacto, raycastHit2D.point, Quaternion.identity);
                StartCoroutine(GenerarLinea(raycastHit2D.point));

            }

            if (raycastHit2D.transform.CompareTag("Jefe"))
            {
                raycastHit2D.transform.GetComponent<Jefe>().TomarDaño(20);
                Instantiate(efectoImpacto, raycastHit2D.point, Quaternion.identity);
                StartCoroutine(GenerarLinea(raycastHit2D.point));

            }

            if (raycastHit2D.transform.CompareTag("Sucubus"))
            {
                raycastHit2D.transform.GetComponent<EnemigoSucubus>().TomarDaño(20);
                Instantiate(efectoImpacto, raycastHit2D.point, Quaternion.identity);
                StartCoroutine(GenerarLinea(raycastHit2D.point));

            }
        }
    }

    IEnumerator GenerarLinea(Vector3 objetivo)
    {
        disparo.enabled = true;
        disparo.SetPosition(0, controladorDisparo.position);
        disparo.SetPosition(1, objetivo);
        yield return new WaitForSeconds(tiempoDisparo);
        disparo.enabled = false;
    }
}
