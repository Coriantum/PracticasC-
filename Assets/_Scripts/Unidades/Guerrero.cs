using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guerrero : Militar
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Guerrero(string n){
        velocidadMov = 40;
        nombre = n;
        Debug.Log("Creado Guerrero " + nombre);
        vida_total = 500;
        vida_actual = vida_total;
        attackPower = 10;
        Nacer();
    }
}
