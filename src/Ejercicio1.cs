using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Cambiar el color de un objeto a un color aleatorio.

public class Ejercicio1 : MonoBehaviour
{
    public uint frameActualizacion = 120;
    private Renderer rd;
    private int frameActual;
    private float[] vectorColor;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Renderer>();
        frameActual = 0;
        vectorColor = new float[3] {Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f)};
        rd.material.color = new Color(vectorColor[0], vectorColor[1], vectorColor[2]);
    }

    // Update is called once per frame
    void Update()
    {
        if (frameActual == frameActualizacion) {
            frameActual = 0;
            int posicionAleatoria = Random.Range(0, 2);
            vectorColor[posicionAleatoria] = Random.Range(0.0f, 1.0f);
            // Actualización de las componentes.
            rd.material.color = new Color(vectorColor[0], vectorColor[1], vectorColor[2]);
        }
        ++frameActual;

    }
}

/**
public class Ejercicio1 : MonoBehaviour
{
    public uint frameActualizacion = 120;
    private Renderer rd;
    private int frameActual;
    private Vector3 vectorColor;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Renderer>();
        frameActual = 0;
        vectorColor = new Vector3(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        rd.material.color = new Color(vectorColor.x, vectorColor.y, vectorColor.z);
    }

    // Update is called once per frame
    void Update()
    {
        ++frameActual;
        if (frameActual == frameActualizacion) {
            frameActual = 0;
            int posicionAleatoria = Random.Range(0, 2);
            switch (posicionAleatoria) {
                case 0:
                    vector
                    rd.material.color.r =
            }
            vectorColor[posicionAleatoria] = Random.Range(0.0f, 1.0f);
            // Actualización de las componentes.
            rd.material.color.r = vectorColor.x;
            rd.material.color.g = vectorColor.y;
            rd.material.color.b = vectorColor.z;   
        }
    }
}
*/
