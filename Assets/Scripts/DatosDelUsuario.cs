﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    [SerializeField] string nombre;
    [SerializeField] int edad;
    [SerializeField] float estatura;
    [SerializeField] bool dona;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es " + nombre + ", tengo " + edad + ", mido " + estatura + " metros y es " + dona + " que soy donante de organos.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
