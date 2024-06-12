using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class ChangerNiveau : MonoBehaviour
{
    [SerializeField] private int _niveauActuel;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "ChangerNiveau")
        {
            SceneManager.LoadScene($"Niveau{_niveauActuel + 1}");
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