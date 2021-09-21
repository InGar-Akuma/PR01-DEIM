using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    
    [SerializeField] float decimal1;
    [SerializeField] float decimal2;
    [SerializeField] float decimal3;

    private string texto1 = "Tus resultados son: ";


    // Start is called before the first frame update
    void Start()
    {
        float resultadoSuma = decimal1 + decimal2 + decimal3;
        float resultadoResta = decimal1 - decimal2 - decimal3;
        float resultadoMult = decimal1 * decimal2 * decimal3;
        float resultadoDiv = decimal1 / decimal2 / decimal3;

        print(texto1);
        print("suma: " + resultadoSuma + " ; resta: " + resultadoResta + " ; multiplicacion: " + resultadoMult + " ; division: " + resultadoDiv);
    }
}
