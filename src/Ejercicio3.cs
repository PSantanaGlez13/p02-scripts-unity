using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    public Vector3 vect1 = new Vector3(0, 0, 0);
    public Vector3 vect2 = new Vector3(0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Magnitud vect1: " + vect1.magnitude);
        Debug.Log("Magnitud vect2: " + vect2.magnitude);
        Debug.Log("Angulos entre vect1 y vect2: " + Vector3.Angle(vect1, vect2));
        Debug.Log("Distancia entre vect1 y vect2: " + Vector3.Distance(vect1, vect2));
        if (vect1.y > vect2.y) {
            Debug.Log("vect1 esta a mayor altura que vect2");
        } else if (vect1.y < vect2.y) {
            Debug.Log("vect2 esta a mayor altura que vect1");
        } else {
            Debug.Log("Los dos vectores estan a la misma altura");
        }  
    }

    // Update is called once per frame
    void Update()
    {
    }
}
