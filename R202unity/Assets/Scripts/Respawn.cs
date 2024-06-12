using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Respawn = GameObject.FindGameObjectWithTag("Respawn");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.gameObject.CompareTag("Obstacles"))
    //     {
    //         if (Respawn != null)
    //         {
    //             transform.position = Respawn.transform.position;
    //         }
    //         else
    //         {
    //             Debug.LogWarning("Aucun objet avec le tag 'Respawn' trouvé dans la scène.");
    //         }
    //     }
    // }
}