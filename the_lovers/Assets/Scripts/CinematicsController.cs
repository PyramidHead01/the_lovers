using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CinematicsController : MonoBehaviour
{

    public Sprite sprite;
    public float[,] grid;
    int vertical = 24, horizontal = 42, columns = 42 * 2, rows = 24 * 2;

    [Header("Rutas")]
    public string rutaIntermedia;
    //\Txt\EscenaPrueba\Dialogo\
    public string[] nombreArchivo;
    public bool build;

    [Header("Texto")]
    public bool mostrarDebugLog = true;
    public List<string> arrayTexto = new List<string>();

    // Start is called before the first frame update
    void Start()
    {

        CrearImagen(nombreArchivo[0]);
        PintarImagen(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator NextImagen()
    {


        for (int i = 1; i < nombreArchivo.Length; i++)
        {
            CrearImagen(nombreArchivo[i]);
            yield return new WaitForSeconds(10);

            //Efecto de transicion

            
            PintarImagen(true);
        }

        yield return null;
    }

   
    void CrearImagen(string nombreArchivo)
    {

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


    }

    void PintarImagen(bool transicion)
    {
        if (!transicion)
        {
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {

                    SpawnTile(i, j, grid[i, j]);
                }
            }
        }
        else
        {
            StartCoroutine(Transicion());
        }

        StartCoroutine(NextImagen());
    }
    private void SpawnTile(int x, int y, float value)
    {

        GameObject g = new GameObject("X: " + x + " Y: " + y);
        g.transform.position = new Vector3(x - (horizontal - 0.5f), y - (vertical - 0.5f));
        var s = g.AddComponent<SpriteRenderer>();
        s.sprite = sprite;

        if (arrayTexto[y].Substring(x, 1) == "B")
        {
            s.color = new Color32(67, 82, 61, 255);
        }

        else
        {
            s.color = new Color32(199, 240, 216, 255);
        }



    }

    IEnumerator Transicion()
    {

        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                SpawnTile(i, j, grid[i, j]);
            }
            yield return null;
        }

    }

}
