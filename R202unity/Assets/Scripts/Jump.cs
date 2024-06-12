using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _Power;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("JumpPad"))
        {
            _rb.AddForce(Vector3.up * _Power);
        }
    }
}
