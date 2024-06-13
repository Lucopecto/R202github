using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldFinish : MonoBehaviour
{
    [SerializeField] public GameObject menuFinUI;


    // Update is called once per frame
    void Start()
    {
        menuFinUI.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ChangerMonde")
        {
            menuFinUI.SetActive(true);
        }
    }

}
