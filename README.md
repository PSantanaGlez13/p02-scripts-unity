# p02-scripts-unity
## Ejercicio 1.
![Ej 1](media/P02-Ejercicio1.gif)

La idea de funcionamiento es asignarle una variable `frameActualizacion` que se encargue de elegir el número de frames que tienen que pasar para que se actualice un color. Este valor es público para que pueda ser accedido desde el inspector y entonces pueda ser modificado.
El contador de frames se actualiza cada frame en el método `Update`. Para el vector de color que se pide se ha utilizado un array de tipo float de tamaño 3, aunque de la manera en la que se está utilizando se podría cambiar por un objeto `Vector3` y funcionaría de la misma manera.
```c#
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
```

## Ejercicio 2.
![Ej 2](media/P02-Ejercicio2.gif)

Este sencillo script se aplica a cada objeto de la escena, él cual escribe su nombre por pantalla.
```c#
public class Ejercicio2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
```

## Ejercicio 3.
![Ej 3](media/P02-Ejercicio3-v2.gif)

Se han empleado métodos de la clase `Vector3` así como propiedades de objetos de la clase para resolver este problema. En el caso de la altura, se ha interpretado que la altura está dada por el eje `y` del vector.
```c#
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
```

## Ejercicio 4.
![Ej 4](media/P02-Ejercicio4.gif)

Este script devuelve la posición del objeto que lo ejecute.
```
public class Ejercicio4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
```

## Ejercicio 5.
![Ej 5](media/P02-Ejercicio5.gif)

Se buscan los `GameObject` con  `GameObject.FindWithTag` y luego se calcula la distancia con el método apropiado de la clase `Vector3`, accediendo a la componente `Transform` de cada objeto.
```
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
```

## Ejercicio 6.
![Ej 6](media/P02-Ejercicio6.gif)

Haciendo uso de `GetKeyDown`, se detecta cuando se pulsa la barra espaciadora. También se definen unas vectores para el desplazamiento de los objetos, el cual se producirá al pulsar la barra espaciadora (sumando estos vectores a las componentes `Transform` de cada objeto). Este script se aplica un objeto invisible de la escena.
```
public class Ejercicio6 : MonoBehaviour
{
    public Vector3 desplazamientoPosicionCubo, desplazamientoPosicionCilindro, desplazamientoPosicionEsfera; 

    // Start is called before the first frame update
    void Start()
    {
        desplazamientoPosicionCilindro = new Vector3(-4f, 0f, 0f);
        desplazamientoPosicionEsfera = new Vector3(4f, 0f, 0f);
        desplazamientoPosicionCubo = new Vector3(0f, 1f, 0f);  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject.FindWithTag("cilindro").GetComponent<Transform>().position += desplazamientoPosicionCilindro;
            GameObject.FindWithTag("cubo").GetComponent<Transform>().position += desplazamientoPosicionCubo;
            GameObject.FindWithTag("esfera").GetComponent<Transform>().position += desplazamientoPosicionEsfera;
        }
    }
}
```

## Ejercicio 7.
![Ej 7](media/P02-Ejercicio7.gif)

La generación de colores aleatorios se ha hecho diferente que en el ejercicio 1, utilizando una función de la clase `Random` que genera un color aleatorio. Por otro lado, se vuelve a hacer uso de `GetKeyDown` para detectar entradas pero esta vez se deja como una propiedad pública, de manera que se pueda aplicar a cada objeto y ajustar el botón al que se desee de manera modular.
```
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
```

## Ejercicio 8.
![Ej 8](media/P02-Ejercicio8.gif)

Este script está aplicado sobre un objeto vacío que tiene como hijos las esferas que se añaden para este ejercicio. Se ha elegido esta manera de trabajar para poder buscar el script más rápidamente a la hora de desactivarlo. En cuanto al funcionamiento del script, se recogen los `GameObject` de cada esfera de tipo 2 y el cubo. Al pulsar el espacio, se calculan las distancias entre todos las esferas de tipo 2 y el cubo. Se mantiene información acerca de la esfera más cercana y lejana. Finalmente, se ajusta la altura de la esfera más cercana y el color de la más lejana. El color se genera con `Random.ColorHSV` y la altura se puede ajustar mediante una propiedad `AUMENTO_ALTURA`.
```
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
```
