using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlechasController : MonoBehaviour
{

    public int valor = 0;

    SoundsHub soundsHub;

    AudioSource audioSourceFlechas;
    //AudioClip sonFlecha;

    void Start()
    {
        audioSourceFlechas = GameObject.Find("HubSounds").GetComponent<AudioSource>();
        soundsHub = GameObject.Find("HubSounds").GetComponent<SoundsHub>();

        //sonFlecha = soundsHub.sonidoFlecha;

    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag != "ComprobadoresPlayer")
        {

            audioSourceFlechas.clip = soundsHub.sonidoFlecha;
            audioSourceFlechas.Play();

            //audioSourceFlechas.PlayOneShot(sonFlecha);

            switch (valor)
            {
                case 0:
                    PlayerPrefs.SetInt("Derecha", 1);
                    break;
                case 1:
                    PlayerPrefs.SetInt("Arriba", 1);
                    break;
                case 2:
                    PlayerPrefs.SetInt("Izquierda", 1);
                    break;
                case 3:
                    PlayerPrefs.SetInt("Abajo", 1);
                    break;
            }

            Destroy(gameObject);

        }

    }

}
