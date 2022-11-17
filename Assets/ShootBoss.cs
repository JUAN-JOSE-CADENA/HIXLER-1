using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBoss : MonoBehaviour
{

    [SerializeField] private Transform controladorDisparo;

    [SerializeField] private float rango;

    [SerializeField] private GameObject efectoImpacto;

    [SerializeField] private LineRenderer disparo;

    [SerializeField] private float tiempoDisparo;

    public Transform jugador;
    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D raycastHit2D = Physics2D.Raycast(controladorDisparo.position, controladorDisparo.right, rango);

        if (raycastHit2D)
        {
            if (raycastHit2D.transform.CompareTag("Player"))
            {
                raycastHit2D.transform.GetComponent<CombateJugador>().TomarDaño(20);
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
