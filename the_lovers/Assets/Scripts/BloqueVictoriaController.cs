using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueVictoriaController : MonoBehaviour
{

    public bool colisionVictoria = false;

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag != "ComprobadoresPlayer")
        {
            colisionVictoria = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.tag != "ComprobadoresPlayer")
        {
            colisionVictoria = false;
        }
    }
}
