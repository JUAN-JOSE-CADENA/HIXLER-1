using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoLava : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<CombateJugador>().TomarDaño(100);
        }
    }
}
