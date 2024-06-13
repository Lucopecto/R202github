using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float rotationVitesse = 2.0f;
    private float direction = 1.0f;

    void Update()
    {
        transform.Rotate(direction * rotationVitesse * Time.deltaTime, 0, 0, Space.Self);
    }
}
