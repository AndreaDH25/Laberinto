using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Win : MonoBehaviour
{
    public GameObject winText;
    public GameObject pausaBoton;
    public void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Se tocan");
        if (collider.CompareTag("Player"))
        {
            winText.SetActive(true);
            pausaBoton.SetActive(false);
        }
    }
}
// panel

//public void (Collider collider){
// if (collider.ComareTag("Player")){
//SceneManager.LoadScene("Win",
//LoadSceneMode.Single);
//} <--- escena nueva


