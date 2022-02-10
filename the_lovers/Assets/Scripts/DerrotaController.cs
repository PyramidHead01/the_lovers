using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DerrotaController : MonoBehaviour
{

    GridManager_v2 GridManager_V2;

    // Start is called before the first frame update
    void Start()
    {
        GridManager_V2 = GetComponent<GridManager_v2>();
    }

    // Update is called once per frame
    void Update()
    {

        if ((GridManager_V2.players[0].transform.position == GridManager_V2.victorias[0].transform.position ||
            GridManager_V2.players[0].transform.position == GridManager_V2.victorias[1].transform.position) &&
            (GridManager_V2.players[1].transform.position == GridManager_V2.victorias[0].transform.position ||
            GridManager_V2.players[1].transform.position == GridManager_V2.victorias[1].transform.position))
        {
            //Debug.Log("ASDASD");
        }
    }
}
