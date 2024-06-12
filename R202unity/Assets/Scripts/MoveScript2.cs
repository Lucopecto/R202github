using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript2 : MonoBehaviour
{
    public float speed = 2.0f; // Vitesse
    public float distance = 5.0f; // distance déplacement axe Z
    private Vector3 startPosition;
    private bool movingRight = false;

	void Start()
	{
        startPosition = transform.position;
        //InvertDirection();
	}
	
	void Update()
	{
        float xOffset = speed * Time.deltaTime;
        if (movingRight)
        {
            transform.position += new Vector3(xOffset, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(xOffset, 0, 0);
        }

        if (Vector3.Distance(startPosition, transform.position) >= distance)
        {
            movingRight = !movingRight;
        }    
    }

    public void InvertDirection()
    {
        movingRight = !movingRight;
    }
}
