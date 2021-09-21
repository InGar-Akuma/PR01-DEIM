using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{

    int valor = 10;


    // Start is called before the first frame update
    void Start()
    {
        while (valor >= 0) 
        {
            print("El valor while es: " + valor);
            valor--;
        }

        for (valor = 10; valor >= 0 ; valor--)
        {
            print("el valor for es: " + valor);
        }
    }

}
