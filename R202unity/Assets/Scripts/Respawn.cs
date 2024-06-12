using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    private GameObject respawnObject;
    public float respawnAuDessus = 2f;  // Ajustez cette valeur selon vos besoins

    void Start()
    {
        respawnObject = GameObject.FindGameObjectWithTag("Respawn");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // Réapparaître le joueur à la position de l'objet de respawn
            if (respawnObject != null)
            {
                Vector3 respawnPosition = respawnObject.transform.position;
                respawnPosition.y += respawnAuDessus;  // Ajouter le décalage en hauteur
                transform.position = respawnPosition;
                //transform.position = respawnObject.transform.position;
            }
            else
            {
                Debug.LogWarning("Aucun objet avec le tag 'Respawn' trouvé dans la scène.");
            }
        }
    }
}