using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{

    bool mov = true;
    public ColisionesPlayer[] col;

    //bool unlockedLeft = true, unlockedRigth = true, unlockedDown = true, unlockedUp = true;

    int i = 0;



    public bool colisionVictoria = false;

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Victoria")
        {
            colisionVictoria = true;
            //print(collision.gameObject.transform.name);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Victoria")
        {
            colisionVictoria = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        /*PlayerPrefs.SetInt("Derecha", 1);
        PlayerPrefs.SetInt("Arriba", 1);
        PlayerPrefs.SetInt("Izquierda", 1);
        PlayerPrefs.SetInt("Abajo", 1);*/
    }

    // Update is called once per frame
    void Update()
    {
        if (mov)
        {
            if (Input.GetKey("d") && !col[0].colisionSuelo && PlayerPrefs.GetInt("Derecha") == 1)
            {
                mov = false;
                i = 0;
                transform.position = new Vector3(transform.position.x + 2f, transform.position.y, transform.position.z);
            }
            if (Input.GetKey("w") && !col[1].colisionSuelo && PlayerPrefs.GetInt("Arriba") == 1)
            {
                mov = false;
                i = 1;
                transform.position = new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z);
            }
            if (Input.GetKey("a") && !col[2].colisionSuelo && PlayerPrefs.GetInt("Izquierda") == 1)
            {
                mov = false;
                i = 2;
                transform.position = new Vector3(transform.position.x - 2f, transform.position.y, transform.position.z);
            }
            if (Input.GetKey("s") && !col[3].colisionSuelo && PlayerPrefs.GetInt("Abajo") == 1)
            {
                mov = false;
                i = 3;
                transform.position = new Vector3(transform.position.x, transform.position.y - 2f, transform.position.z);
            }
        }


        if ((Input.GetKeyUp("d") && i == 0) || (Input.GetKeyUp("s") && i == 3) || (Input.GetKeyUp("w") && i == 1) || (Input.GetKeyUp("a") && i == 2))
        {
            mov = true;
        }
    }
}
