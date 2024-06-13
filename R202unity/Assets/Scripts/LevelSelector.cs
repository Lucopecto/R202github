using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public GameObject canvas;
    public TMP_InputField inputField;

    void Start()
    {
        canvas.SetActive(false);

        inputField.onSubmit.AddListener(OnSubmit);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            canvas.SetActive(true);

            if (canvas.activeSelf)
            {
                inputField.text = "";
                inputField.ActivateInputField();
            }
        }
    }

    void OnSubmit(string level)
    {
        int levelNumber;
        if (int.TryParse(level, out levelNumber))
        {
            LoadLevel(levelNumber);
        }
        else
        {
            Debug.Log("Veuillez entrer un numéro de niveau valide.");
        }

        canvas.SetActive(false);
    }

    void LoadLevel(int levelNumber)
    {
        SceneManager.LoadScene("Niveau" + levelNumber);
    }
}