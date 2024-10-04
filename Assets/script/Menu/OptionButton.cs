using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionButton : MonoBehaviour
{
    public GameObject menuOpciones;
    public GameObject menuPausa;

    public void Opciones ()
    {
        menuOpciones.SetActive(true); //se enciende la opciones
        menuPausa.SetActive(false); //  se apaga
    }
     public void SalirOption ()
    {
        menuOpciones.SetActive(true); //se apaga
        menuPausa.SetActive(false); // se enciende el pausa
    }
}
