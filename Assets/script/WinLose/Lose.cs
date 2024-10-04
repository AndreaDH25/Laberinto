using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Lose : MonoBehaviour
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