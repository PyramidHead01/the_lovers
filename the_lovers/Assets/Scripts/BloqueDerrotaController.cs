using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueDerrotaController : MonoBehaviour
{

    public bool colisionDerrota = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "ComprobadoresPlayer")
        {
            colisionDerrota = true;
            Debug.Log("DERROTA");
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "ComprobadoresPlayer")
        {
            colisionDerrota = false;
        }
    }
}
