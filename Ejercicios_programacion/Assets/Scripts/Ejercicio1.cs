using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    public int num1 = 42;
    
    [SerializeField] float decimal1 = 22.2f ;

    public bool boolean1 = true;

    [SerializeField] string texto1 = "ash nazg thrakatuluk agh burzum-ishi krimpatul";


    // Start is called before the first frame update
    void Start()
    {
        //num1 = 23;
        decimal1 = 33.3f;
        //boolean1 = false;
        //texto1 = "Hola mundo";

        print(num1);
        print(texto1);
        print(boolean1 + " " + decimal1);
    }
}
