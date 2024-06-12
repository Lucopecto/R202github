using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

private Vector3 normalizeDirection;

	public Transform target;
	//public float speed = 5f;


public Transform movingCubeDestination;
        public Transform firstPosition;
   
        public float speed = 1.0f;
  public float distanceThreshold = 0.1f;
	void Start()
	{
		//normalizeDirection = (target.position - transform.position).normalized;
	}
	
	void Update()
	{

// float step = speed * Time.deltaTime;
//         if (whereDoIGo == true)
//         {
//             transform.position = Vector3.MoveTowards(transform.position, movingCubeDestination.position, step);
//             whereDoIGo = false;
//         }
//         else if (whereDoIGo == false)
//         {
//             transform.position = Vector3.MoveTowards(transform.position, firstPosition.position, step);
//             whereDoIGo = true;
//         }		// transform.position += normalizeDirection * speed * Time.deltaTime;
            float step = speed * Time.deltaTime;
   
                transform.position = Vector3.MoveTowards(transform.position, movingCubeDestination.position, step);
           if(Vector3.Distance(movingCubeDestination.position,transform.position) <= distanceThreshold)
            {
                transform.position = new Vector3(1f,0f,0f);
            }	
    }

}