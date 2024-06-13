using UnityEngine;

public class GlisserCharactere : MonoBehaviour
{
public float slipperyFriction = 0.0f; // Coefficient de friction pour les surfaces glissantes
    public float normalFriction = 1.0f;   // Coefficient de friction pour les surfaces normales

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Appliquer la friction glissante au joueur
            Rigidbody playerRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            if (playerRigidbody != null)
            {
                playerRigidbody.drag = slipperyFriction;
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Réinitialiser la friction normale du joueur
            Rigidbody playerRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            if (playerRigidbody != null)
            {
                playerRigidbody.drag = normalFriction;
            }
        }
    }
}