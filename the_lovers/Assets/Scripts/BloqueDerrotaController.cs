using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BloqueDerrotaController : MonoBehaviour
{

    public bool colisionDerrota = false;


    GridManager_v2 gridManager_v2;

    void Start()
    {
        gridManager_v2 = GameObject.Find("GridManager").GetComponent<GridManager_v2>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "ComprobadoresPlayer")
        {
            colisionDerrota = true;
            Debug.Log("DERROTA");

            StartCoroutine(gridManager_v2.TransicionGame(0));


        }
    }



}
