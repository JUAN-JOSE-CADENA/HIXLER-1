using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MenuOpciones : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    [SerializeField] private AudioMixer audioMixerSonido;

    public void PantallaCompleta(bool pantallaCompleta)
    {
        Screen.fullScreen = pantallaCompleta;
    }


    public void CambiarVolumenMusica(float volumenMusica)
    {
        audioMixer.SetFloat("Musica", volumenMusica);
    }

    public void CambiarVolumenSonido(float volumenSonido)
    {
        audioMixerSonido.SetFloat("Sonido", volumenSonido);
    }
}
