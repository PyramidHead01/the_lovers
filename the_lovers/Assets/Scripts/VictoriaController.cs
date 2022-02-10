using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoriaController : MonoBehaviour
{

    public BloqueVictoriaController[] bloqueVictoriaController;
    //public BloqueDerrotaController[] bloqueDerrotaController;

    // Start is called before the first frame update
    void Start()
    {
        /*GridManager_V2 = GetComponent<GridManager_v2>();
        bloqueVictoriaController[0] = GridManager_V2.victorias[0].GetComponent<BloqueVictoriaController>();
        bloqueVictoriaController[1] = GridManager_V2.victorias[1].GetComponent<BloqueVictoriaController>();*/
    }

    // Update is called once per frame
    void Update()
    {
        if (bloqueVictoriaController[0].colisionVictoria && bloqueVictoriaController[1].colisionVictoria)
        {
            Debug.Log("VICTORIA");
        }
        /*if (bloqueDerrotaController[0].colisionDerrota && bloqueDerrotaController[1].colisionDerrota)
        {
            Debug.Log("DERROTA");
        }*/
    }



}
