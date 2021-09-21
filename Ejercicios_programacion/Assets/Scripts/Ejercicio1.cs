using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    private int num1 = 42;
    
    private float decimal1 = 22.2f ;

    private bool boolean1 = true;

    private string texto1 = "ash nazg thrakatuluk agh burzum-ishi krimpatul";


    // Start is called before the first frame update
    void Start()
    {
        print("respuesat: " + num1);
        print(texto1);
        print(boolean1 + " " + decimal1);
    }
}
