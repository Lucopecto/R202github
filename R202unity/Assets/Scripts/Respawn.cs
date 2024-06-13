using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private AudioClip deathsound;
    [SerializeField] private AudioClip spawnsound;

    AudioSource audio;

    private GameObject respawnObject;
    public float respawnAuDessus = 2f; 
    public float respawnDelay = 2f;  
    private Renderer playerRenderer;
    private Collider playerCollider;

    void Start()
    {
        respawnObject = GameObject.FindGameObjectWithTag("Respawn");
        playerRenderer = GetComponent<Renderer>();
        playerCollider = GetComponent<Collider>();
        audio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            if (respawnObject != null)
            {
                
                audio.PlayOneShot(dashsound, 0.7f);
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
        //désactive  rendu/collisions joueur
        playerRenderer.enabled = false;
        playerCollider.enabled = false;

        yield return new WaitForSeconds(delay);

        Vector3 respawnPosition = respawnObject.transform.position;
        respawnPosition.y += respawnAuDessus;
        transform.position = respawnPosition;

        playerRenderer.enabled = true;
        playerCollider.enabled = true;
    }
}