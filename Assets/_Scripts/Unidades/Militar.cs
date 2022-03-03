using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Militar : Persona
{
    private int attackPower;
    private int attackRange;

    //Constructor militar
    public Militar(string n, int puntosAtaque){
        Nacer();
        velocidadMov = 40;
        nombre = n;
        Debug.Log("Creado Militar" + nombre);
        vida_total = 500;
        vida_actual = vida_total;
        attackPower = 10;
    }

    public int Atacar(){
        if(!viva){
            return 0;
        }
        Debug.Log(nombre + "Atacó con " + attackPower);
        return attackPower;
    }

    public override string ToString(){
        return "Militar: Nome" + nombre + ", velocidad de movimiento: "+ velocidadMov + ", vida actual: " + vida_actual + ", poder de ataque: "+ attackPower; 
    }

}
