using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edificios : PC
{
    private string tipo;

    public Edificios(string n){
        vida_total = 500;
        vida_actual = vida_total;
        nombre = n;
        Debug.Log("Creado Edificio " + nombre);
        Nacer();
    }

}
