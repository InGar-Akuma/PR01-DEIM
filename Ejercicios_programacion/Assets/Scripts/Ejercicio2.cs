using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{

    [SerializeField] string nombre;


    // Start is called before the first frame update
    void Start()
    {
        Saludar();

    }

    void Saludar()
    {
        print("Saludos terricola " + nombre);

    }

}
