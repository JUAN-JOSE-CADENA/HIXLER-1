using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoPinchos : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<CombateJugador>().TomarDaño(50);
        }
    }
}
