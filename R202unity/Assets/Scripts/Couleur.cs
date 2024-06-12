using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Couleur : MonoBehaviour
{    
    public Color newColor = Color.red; // Couleur par défaut
    // Start is called before the first frame update
    void Start()
    {
        ChangeCubeColor(newColor);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeCubeColor(Color color)
    {
        Renderer cubeRendu = GetComponent<Renderer>();      
        cubeRendu.material.color = color;
    }
}
