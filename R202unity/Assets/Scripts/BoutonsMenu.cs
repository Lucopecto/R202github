using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoutonsMenu : MonoBehaviour
{
    public void Jouer()
    {
        SceneManager.LoadScene($"Niveau1");
    }

    public void Quitter()
    {
        Application.Quit();
    }
}
