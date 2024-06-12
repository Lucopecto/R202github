using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript1 : MonoBehaviour {

    public float speed = 2.0f; 
    public float distance = 5.0f;
    private Vector3 startPosition;
    private bool movingForward = true;

	void Start()
	{
        startPosition = transform.position;
	}
	
	void Update()
	{
        float zOffset = Mathf.PingPong(Time.time * speed, distance);
        transform.position = startPosition + new Vector3(0, 0, zOffset);
        
        // float zOffset = speed * Time.deltaTime;
        // if (movingForward)
        // {
        //     transform.position -= new Vector3(0, 0, zOffset);
        // }
        // else
        // {
        //     transform.position += new Vector3(0, 0, zOffset);
        // }

        // if (Vector3.Distance(startPosition, transform.position) >= distance)
        // {
        //     movingForward = !movingForward;
        // }
    }
}