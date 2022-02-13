using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoriaController : MonoBehaviour
{

    public BloqueVictoriaController[] bloqueVictoriaController;

    GridManager_v2 gridManager_v2;
    SoundsHub soundsHub;

    void Start()
    {
        gridManager_v2 = GetComponent<GridManager_v2>();
        soundsHub = GameObject.Find("HubSounds").GetComponent<SoundsHub>();
    }

    void Update()
    {
        if (bloqueVictoriaController[0].colisionVictoria && bloqueVictoriaController[1].colisionVictoria)
        {

            Debug.Log("VICTORIA");


            StartCoroutine(gridManager_v2.TransicionGame(1));

            //guarda ruta intermedia y ruta final en un player prefs
            /*PlayerPrefs.SetString("rutaIntermedia", gridManager_v2.arrayTexto[gridManager_v2.arrayTexto.Count - 1].Substring(gridManager_v2.columns));
            PlayerPrefs.SetString("nombreArchivo", gridManager_v2.arrayTexto[gridManager_v2.arrayTexto.Count - 2].Substring(gridManager_v2.columns));

            //hace un if donde si es cinematic o game carga un modelo o otro
            if (gridManager_v2.arrayTexto[gridManager_v2.arrayTexto.Count - 3].Substring(gridManager_v2.columns) == "Cinematics")
            {
                SceneManager.LoadScene("Cinematics");
            }
            else
            {
                SceneManager.LoadScene("Game");
            }*/



        }

    }

}
