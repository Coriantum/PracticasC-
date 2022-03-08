using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arquero : Militar
{
    public Arquero(string n){
        Nacer();
        velocidadMov = 40;
        nombre = n;
        Debug.Log("Creado Arquero" + nombre);
        vida_total = 500;
        vida_actual = vida_total;
        attackPower = 5;
    }
}
