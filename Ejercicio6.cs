using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
    public Vector3 desplazamientoPosicionCubo, desplazamientoPosicionCilindro, desplazamientoPosicionEsfera; 

    // Start is called before the first frame update
    void Start()
    {
        // Posiciones absolutas
        //nuevaPosicionCilindro = new Vector3(-2f, 0.281f, 0f);
        //nuevaPosicionEsfera = new Vector3(2f, -0.279f, 0f);
        //nuevaPosicionCubo = new Vector3(0f, 1f, 0f); 

        // Posiciones relativas
        desplazamientoPosicionCilindro = new Vector3(-4f, 0f, 0f);
        desplazamientoPosicionEsfera = new Vector3(4f, 0f, 0f);
        desplazamientoPosicionCubo = new Vector3(0f, 1f, 0f);  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            // Posiciones absolutas
            //GameObject.FindWithTag("cilindro").GetComponent<Transform>().position = nuevaPosicionCilindro;
            //GameObject.FindWithTag("cubo").GetComponent<Transform>().position = nuevaPosicionCubo;
            //GameObject.FindWithTag("esfera").GetComponent<Transform>().position = nuevaPosicionEsfera;
            
            // Posiciones relativas
            GameObject.FindWithTag("cilindro").GetComponent<Transform>().position += desplazamientoPosicionCilindro;
            GameObject.FindWithTag("cubo").GetComponent<Transform>().position += desplazamientoPosicionCubo;
            GameObject.FindWithTag("esfera").GetComponent<Transform>().position += desplazamientoPosicionEsfera;
        }
    }
}
