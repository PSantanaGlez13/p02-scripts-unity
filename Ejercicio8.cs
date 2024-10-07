using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8 : MonoBehaviour
{
    public uint AUMENTO_ALTURA = 1;
    private GameObject cubo;
    private GameObject[] objetos;
    // Start is called before the first frame update
    void Start()
    {
        cubo = GameObject.FindWithTag("cubo");
        objetos = GameObject.FindGameObjectsWithTag("tipo2");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            int indice_mayor_distancia = 0;
            float mayor_distancia = float.NegativeInfinity;
            int indice_menor_distancia = 0;
            float menor_distancia = float.PositiveInfinity;
            // Búsqueda de las esferas más cercana y más lejana.
            for (int indice_actual = 0; indice_actual < objetos.Length; ++indice_actual) {
                float distancia_actual = Vector3.Distance(cubo.transform.position, objetos[indice_actual].transform.position);
                if (mayor_distancia < distancia_actual) {
                    indice_mayor_distancia = indice_actual;
                    mayor_distancia = distancia_actual;
                }
                if (menor_distancia > distancia_actual) {
                    indice_menor_distancia = indice_actual;
                    menor_distancia = distancia_actual;
                }
            }
            // Ajuste de altura.
            Vector3 nuevaAltura = objetos[indice_menor_distancia].GetComponent<Transform>().position;
            nuevaAltura.y += AUMENTO_ALTURA;
            objetos[indice_menor_distancia].GetComponent<Transform>().position = nuevaAltura;

            // Cambio de color.
            Color nuevoColor = Random.ColorHSV();
            objetos[indice_mayor_distancia].GetComponent<Renderer>().material.color = nuevoColor;
        }
    }
}
