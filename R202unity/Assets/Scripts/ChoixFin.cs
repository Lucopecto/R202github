using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    #if UNITY_EDITOR
    using UnityEditor;
    #endif

public class ChoixFin : MonoBehaviour
{
    void Start()
	{

	}

    void Update()
	{

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Jouer")
        {
            SceneManager.LoadScene("Menu");
        }
        else if(other.tag == "Quitter")
        {
            #if UNITY_EDITOR
            EditorApplication.isPlaying = false;
            #else
            Application.Quit();
            #endif
            Debug.Log("Jeu quitté");
        }
    }
}