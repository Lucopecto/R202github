using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript1 : MonoBehaviour {

    public float vitesse = 2.0f; 
    public float distance = 5.0f;
    private Vector3 positionDebut;

	void Start()
	{
        positionDebut = transform.position;
	}
	
	void Update()
	{
        float zAxe = Mathf.PingPong(Time.time * vitesse, distance);
        transform.position = positionDebut + new Vector3(0, 0, zAxe);
    }
}