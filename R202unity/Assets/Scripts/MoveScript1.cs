using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript1 : MonoBehaviour {

    // private Vector3 normalizeDirection;

	//public Transform target;
	//public float speed = 5f;


    // public Transform movingCubeDestination;
    // public Transform firstPosition;
   
    // public float speed = 1.0f;
    // public float distanceThreshold = 0.1f;

    public float speed = 2.0f; // Vitesse de déplacement
    public float distance = 5.0f; // Distance totale de déplacement sur l'axe Z
    private Vector3 startPosition;
    private bool movingForward = true;

	void Start()
	{
		//normalizeDirection = (target.position - transform.position).normalized;
        startPosition = transform.position;
	}
	
	void Update()
	{

    // float step = speed * Time.deltaTime;
    //     if (whereDoIGo == true)
    //     {
    //         transform.position = Vector3.MoveTowards(transform.position, movingCubeDestination.position, step);
    //         whereDoIGo = false;
    //     }
    //     else if (whereDoIGo == false)
    //     {
    //         transform.position = Vector3.MoveTowards(transform.position, firstPosition.position, step);
    //         whereDoIGo = true;
    //     }	// transform.position += normalizeDirection * speed * Time.deltaTime;
    //     float step = speed * Time.deltaTime;
    //     transform.position = Vector3.MoveTowards(transform.position, movingCubeDestination.position, step);

    //     if(Vector3.Distance(movingCubeDestination.position,transform.position) <= distanceThreshold)
    //     {
    //         transform.position = new Vector3(1f,0f,0f);
    //     }	

        float zOffset = speed * Time.deltaTime;
        if (movingForward)
        {
            transform.position += new Vector3(0, 0, zOffset);
        }
        else
        {
            transform.position -= new Vector3(0, 0, zOffset);
        }

        // Vérifier si le cube a atteint la distance maximale et inverser la direction
        if (Vector3.Distance(startPosition, transform.position) >= distance)
        {
            movingForward = !movingForward;
        }



    }
}