using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CreateLevel : MonoBehaviour
{

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

        #endregion

        #region 

        #endregion

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
