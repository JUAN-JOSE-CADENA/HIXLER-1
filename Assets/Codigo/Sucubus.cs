using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sucubus : MonoBehaviour
{

    [SerializeField] public Transform jugador;

    [SerializeField] private float distancia;

    public Vector3 puntoInicial;

    public Animator animator;

    private SpriteRenderer spriteRenderer;


    private void Start()
    {
        animator = GetComponent<Animator>();
        puntoInicial = transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    private void Update()
    {
        distancia = Vector2.Distance(transform.position, jugador.position);
        animator.SetFloat("Distancia", distancia);
    }


    public void Girar(Vector3 objetivo)
    {
        if (transform.position.x < objetivo.x)
        {
            spriteRenderer.flipX = true;
        }

        else
        {
            spriteRenderer.flipX = false;
        }
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            //if (other.GetContact(0).normal.y <= -0.9)
            //{
            //    GameObject.FindGameObjectWithTag("Puerta").GetComponent<Puerta>().EnemigoEliminado();
            //    Destroy(gameObject);
            //}
            other.gameObject.GetComponent<CombateJugador>().TomarDa�o(20, other.GetContact(0).normal);
        }
    }
}
