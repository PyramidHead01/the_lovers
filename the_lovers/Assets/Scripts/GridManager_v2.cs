using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GridManager_v2 : MonoBehaviour
{

    public Sprite sprite;
    public float[,] grid;
    int vertical, horizontal, columns, rows;

    public GameObject player1, player2;


    [Header("Rutas")]
    public string rutaIntermedia;
    //\Txt\EscenaPrueba\Dialogo\
    public string nombreArchivo;
    public bool build;

    [Header("Texto")]
    public bool mostrarDebugLog = true;
    public List<string> arrayTexto = new List<string>();


    // Start is called before the first frame update
    void Start()
    {
        vertical = 24;
        horizontal = 42;

       

        columns = horizontal * 2;
        rows = vertical * 2;
        grid = new float[columns, rows];


        //Coge la ruta, dependiendo de la variable activa, la cogera los datos que hay en una build, o en la ruta predifinida si no esta buildeada
        #region cogerRuta
        string ruta;

        if (mostrarDebugLog)
            Debug.Log("Ruta: " + rutaIntermedia + "\nTxt Usado: " + nombreArchivo);

        nombreArchivo = nombreArchivo + ".txt";
        if (build)
        {
            ruta = nombreArchivo;
        }
        else
        {
            ruta = Application.dataPath + rutaIntermedia + nombreArchivo;

        }
        #endregion

        //Aqui el array del texto se llena solo la parte correspondiente, que esta entre **, que significa un idioma nuevo
        #region llenarArray

        //string[] arrayAux = new string[modificableDialogo.arrayTexto.Count / 2];
        string[] arrayAux = File.ReadAllLines(ruta);

        foreach (string line in arrayAux)
        {

            arrayTexto.Add(line);

        }

        arrayTexto.Reverse();

        #endregion



        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                
                SpawnTile(i, j, grid[i, j]);
            }
        }

    }

    private void SpawnTile(int x, int y, float value)
    {

        //Debug.Log(x);

        if (arrayTexto[y].Substring(x, 1) == "C")
        {
            //Aqui instanciar player1
            


            GameObject newObject = Instantiate(player1, new Vector3(x - (horizontal - 0.5f), y - (vertical - 0.5f)), Quaternion.identity);  // instatiate the object
            newObject.transform.localScale = new Vector3(25, 25, this.transform.localScale.z);



        }
        else if (arrayTexto[y].Substring(x, 1) == "D")
        {





            GameObject newObject = Instantiate(player2, new Vector3(x - (horizontal - 0.5f), y - (vertical - 0.5f)), Quaternion.identity);  // instatiate the object
            newObject.transform.localScale = new Vector3(25, 25, this.transform.localScale.z);


            //Aqui instanciar player2
            //Instantiate(player1, new Vector3(x - (horizontal - 0.5f), y - (vertical - 0.5f)), Quaternion.identity);
        }

        GameObject g = new GameObject("X: " + x + " Y: " + y);
        g.transform.position = new Vector3(x - (horizontal - 0.5f), y - (vertical - 0.5f));
        var s = g.AddComponent<SpriteRenderer>();
        s.sprite = sprite;

        if (arrayTexto[y].Substring(x, 1) == "B")// || arrayTexto[y].Substring(x, 1) == "C" || arrayTexto[y].Substring(x, 1) == "D")
        {

            //if (y > 24)
                s.color = new Color32(67, 82, 61, 255);
            /*else
                s.color = new Color32(199, 240, 216, 255);*/
        }

        else
        {
            //if (y > 24)
                s.color = new Color32(199, 240, 216, 255);
            /*else
                s.color = new Color32(67, 82, 61, 255);*/
        }



    }

    // Update is called once per frame
    void Update()
    {

    }
}
