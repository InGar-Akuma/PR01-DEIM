using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{

    int valor = 0;


    // Start is called before the first frame update
    void Start()
    {
         
    }

    void Update()
    {
        if (valor <= 100)
        {
            print(valor);
            valor++;
        }
        if (valor == 101)
        {
            print("Es mayor que 100");
            valor = 102;
        }
    }
}
