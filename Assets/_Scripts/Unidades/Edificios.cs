using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edificios : PC
{
    private string tipo;

    public Edificios(){
        Nacer();
        Debug.Log("Creado Edificio");
        vida_total = 500;
        vida_actual = vida_total;
    }

}
