using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7 : MonoBehaviour
{
    public KeyCode botonCambioDeColor = KeyCode.None;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(botonCambioDeColor)) {
            gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
        }
    }
}
