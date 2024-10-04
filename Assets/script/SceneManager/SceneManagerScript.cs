using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour //Manipulaciones dentro de la escena
{
    public void Menu()
    {
        SceneManager.LoadScene("Menú", LoadSceneMode.Single);//Carga las escena principal del juego
    }
    public void Options()
    {
        SceneManager.LoadScene("Options", LoadSceneMode.Single);
    }
    public void Niveles()
    {
        SceneManager.LoadScene("MenuNiveles", LoadSceneMode.Single);
    }
    public void Nivel1()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
    public void Nivel2()
    {
        SceneManager.LoadScene("NivelDos", LoadSceneMode.Single);
    }
    public void Nivel3()
    {
        SceneManager.LoadScene("NivelTres", LoadSceneMode.Single);
    }
    public void Nivel4()
    {
        SceneManager.LoadScene("NivelCuatro", LoadSceneMode.Single);
    }
    public void GameQuit(/*Aqui mete las escenas*/)
    {
        Application.Quit(); //cerrar juego
        Debug.Log("Se apagó");
    }
}
