using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionesPlayer : MonoBehaviour
{

    public bool colision = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Suelo")
        {
            colision = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Suelo")
        {
            colision = false;
        }
    }

}
