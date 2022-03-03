using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aldeano : Civil
{
    //constructor aldeano
    public Aldeano(string n){
        Nacer();
        velocidadMov = 50;
        nombre = n;
        Debug.Log("Creado aldeano " + nombre);
        vida_total = 100;
        vida_actual = vida_total;
        
    }

    public override string trabajar(){
        if(!viva){
            return "No puedo,estoy muerto";
        }
        Debug.Log("Estoy trabajando");
        return "estoy trabajando";
    }

    //Metodo tostring para aldeano y militar que devuelva string con todos los atributos del objeto

    public override string ToString(){
        return "Aldeano: Nome" + nombre + ", velocidad de movimiento: "+ velocidadMov + ", vida actual: " + vida_actual; 
    }


}
