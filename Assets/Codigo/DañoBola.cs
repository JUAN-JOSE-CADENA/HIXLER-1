using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoBola : MonoBehaviour
{
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Player"))
    //    {
    //        collision.GetComponent<CombateJugador>().TomarDaño(20);
    //    }
    //}
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<CombateJugador>().TomarDaño(20, other.GetContact(0).normal);
        }
    }
}
