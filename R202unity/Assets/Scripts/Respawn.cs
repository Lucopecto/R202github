using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private GameObject respawnObject;
    public float respawnAuDessus = 2f;  // Ajustez cette valeur selon vos besoins
    public float respawnDelay = 2f;  // Délai de 2 secondes avant de réapparaître
    private Renderer playerRenderer;
    private Collider playerCollider;

    void Start()
    {
        respawnObject = GameObject.FindGameObjectWithTag("Respawn");
        playerRenderer = GetComponent<Renderer>();
        playerCollider = GetComponent<Collider>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            if (respawnObject != null)
            {
                StartCoroutine(RespawnAfterDelay(respawnDelay));
            }
            else
            {
                Debug.LogWarning("Aucun objet avec le tag 'Respawn' trouvé dans la scène.");
            }
        }
    }

    private IEnumerator RespawnAfterDelay(float delay)
    {
        // Désactive le rendu et les collisions du joueur
        playerRenderer.enabled = false;
        playerCollider.enabled = false;

        yield return new WaitForSeconds(delay);

        Vector3 respawnPosition = respawnObject.transform.position;
        respawnPosition.y += respawnAuDessus;  // Ajouter le décalage en hauteur
        transform.position = respawnPosition;

        // Réactive le rendu et les collisions du joueur
        playerRenderer.enabled = true;
        playerCollider.enabled = true;
    }
}