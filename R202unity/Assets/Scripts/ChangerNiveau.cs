using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangerNiveau : MonoBehaviour
{
    [SerializeField] private int _niveauActuel;
    [SerializeField] private AudioClip nextlevelsound;

    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "ChangerNiveau")
        {
            NiveauSuivant();
        }
    }

    public void NiveauSuivant() 
    {
        audio.PlayOneShot(nextlevelsound, 0.7f);
        SceneManager.LoadScene($"Niveau{_niveauActuel + 1}");
    }

    public void QuitGame()
    {
        SceneManager.LoadScene($"Menu");
    }
}