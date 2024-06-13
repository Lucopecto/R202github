using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldFinish : MonoBehaviour
{
    [SerializeField] public GameObject menuFinUI;

    private float opaciteCanvas = 0f;
    private bool mondeFini = false;


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ChangerMonde")
        {
            NiveauSuivant();
        }
    }

}
