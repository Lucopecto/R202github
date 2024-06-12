using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangerNiveau : MonoBehaviour
{
    [SerializeField] private int _niveauActuel;



    private void OnTriggerEnter(Collider other){
        if(other.tag == "ChangerNiveau"){
            SceneManager.LoadScene($"Niveau1");
        }
    }

}
