using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{

    private Rigidbody2D rb2D;

    private float movimientoHorizontal;

    [SerializeField] private float velocidadDeMovimiento;

    [Range(0, 0.3f)] [SerializeField] private float suavizadoDeMovimiento;

    private Vector3 velocidad = Vector3.zero;

    private bool mirandoDerecha = true;


    //salto

    [SerializeField] private float fuerzaDeSalto;

    [SerializeField] private LayerMask queEsSuelo;

    [SerializeField] private Transform controladorSuelo;

    [SerializeField] private Vector3 dimensionesCaja;

    [SerializeField] private bool enSuelo;

    private bool salto = false;


    //ANIMACION

    private Animator animator;

    // Start is called before the first frame update
    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        movimientoHorizontal = Input.GetAxisRaw("Horizontal") * velocidadDeMovimiento;

        animator.SetFloat("Horizontal", Mathf.Abs(movimientoHorizontal));

        animator.SetFloat("VelocidadY", rb2D.velocity.y);


        if (Input.GetButtonDown("Jump"))
        {
            salto = true;
        }
    }


    private void FixedUpdate()
    {
        enSuelo = Physics2D.OverlapBox(controladorSuelo.position, dimensionesCaja, 0f, queEsSuelo);

        animator.SetBool("enSuelo", enSuelo);

        //Mover
        Mover(movimientoHorizontal * Time.fixedDeltaTime, salto);

        salto = false;
    }


    private void Mover(float mover, bool saltar)
    {
        Vector3 velocidadObjeto = new Vector2(mover, rb2D.velocity.y);

        rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, velocidadObjeto, ref velocidad, suavizadoDeMovimiento);

        if(mover >0 && !mirandoDerecha)
        {
            //Girar
            Girar();
        }

        else if(mover <0 && mirandoDerecha)
        {
            //Girar
            Girar();
        }

        if(enSuelo && saltar)
        {
            enSuelo = false;
            rb2D.AddForce(new Vector2(0f, fuerzaDeSalto));
        }
    }


    private void Girar()
    {
        mirandoDerecha = !mirandoDerecha;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(controladorSuelo.position, dimensionesCaja);
    }

}
