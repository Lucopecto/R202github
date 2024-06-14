using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jouermusique : MonoBehaviour
{
    [SerializeField] AudioClip music;

    AudioSource audio;
    
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        audio.PlayOneShot(music, 0.7f);
    }
}
