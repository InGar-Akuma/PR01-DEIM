using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{

    [SerializeField] int numero;
    float numAzar;  


    // Start is called before the first frame update
    void Start()
    {
       while(numAzar != numero)
        {
            numAzar = Random.Range(0, 11);
            print(numAzar);
        }
       
       if (numAzar == numero)
        {
            print("¡Coinciden! " + numAzar);
        }

    }

}
