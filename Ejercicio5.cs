using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject cilindro = GameObject.FindWithTag("cilindro");
        GameObject cubo = GameObject.FindWithTag("cubo"); 
        // Debug.Log("Distancia entre cilindro y cubo: " + Vector3.Distance(cilindro.transform.position, cubo.transform.position));
        Debug.Log("Distancia entre esfera y cilindro: " + Vector3.Distance(cilindro.transform.position, gameObject.transform.position));
        Debug.Log("Distancia entre esfera y cubo: " + Vector3.Distance(cubo.transform.position, gameObject.transform.position));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
