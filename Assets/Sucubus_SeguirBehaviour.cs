using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sucubus_SeguirBehaviour : StateMachineBehaviour
{

    [SerializeField] private float velocidadMovimiento;

    [SerializeField] private float tiempoBase;

    private float tiempoSeguir;

    private Transform jugador;

    private Sucubus sucubus;


    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        jugador = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        sucubus = animator.gameObject.GetComponent<Sucubus>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.transform.position = Vector2.MoveTowards(animator.transform.position, jugador.position, velocidadMovimiento * Time.deltaTime);
        sucubus.Girar(jugador.position);
        tiempoSeguir -= Time.deltaTime;

        if(tiempoSeguir <= 0)
        {
            animator.SetTrigger("Volver");
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
