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

    public void Jouer()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
        Debug.Log("Jeu quitté");
    }
}