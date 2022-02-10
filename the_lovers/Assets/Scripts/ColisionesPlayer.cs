using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionesPlayer : MonoBehaviour
{

    public bool colisionSuelo = false, colisionVictoria = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Suelo")
        {
            colisionSuelo = true;
        }
        if (collision.gameObject.tag == "Victoria")
        {
            colisionVictoria = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Suelo")
        {
            colisionSuelo = false;
        }
        if (collision.gameObject.tag == "Victoria")
        {
            colisionVictoria = false;
        }
    }

}
