using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{

    [SerializeField] int valor;


    // Start is called before the first frame update
    void Start()
    {
        while (valor >= 0) 
        {
            print(valor);

            if (valor == 100)
            {
                print("Queda mucho");
            }

            if (valor == 5)
            {
                print("Queda poco");
            }
            

            if (valor == 0) 
            {
                print("Has llegadoa cero");
            }

            valor--;
        }
         

    }

}
