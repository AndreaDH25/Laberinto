using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpriteController : MonoBehaviour
{
   public GameObject Pausa;
   public Sprite pauseSprite;
   public Sprite playSprite;
   
   void Start()
   {
    Pausa = gameObject;
    Sprite Load(string imageName, string spriteName)
    {
        Sprite[] all = Resources.LoadAll<Sprite>(imageName); //mama con las dos imagenes
        foreach ( var s in all) //se pone en plan creizi a buscarlas
        {
            if (s.name == spriteName) // si la s. imagenes es igual sprite
            {
                return s; //nos devuelve el sprite
            }
        }
        return null; //se deja de poner creizi y se para 
    }
    // a quien se le hace la accion
    playSprite = Load("play-pause", "play"); //sprite play
    pauseSprite = Load("play-pause", "pause"); //sprite pausa
    //nombre variable = carga (la imagen x, la parte x)
   }
   void Update ()
   {
    if (Time.timeScale == 0)
   
        {
            Pausa.GetComponent<Image>().sprite = playSprite;
        }
        else
        {
            Pausa.GetComponent<Image>().sprite = pauseSprite;
        }

   }
}
