using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool enPause = false;
    public GameObject menuPauseUI;

    void Start()
    {
        Resume();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (enPause) 
            {
                Resume();
            }
            else
            {
                setPause();
            }
        }
    }

    public void Resume()
    {
        menuPauseUI.SetActive(false);
        Time.timeScale = 1f;
        enPause = false;
    }

    void setPause()
    {
        menuPauseUI.SetActive(true);
        Time.timeScale = 0f;
        enPause = true;
    }

    public void RetourMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
        enPause = false;
    }

    public void Recommencer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
        enPause = false;
    }

}
