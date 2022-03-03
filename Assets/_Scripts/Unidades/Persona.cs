using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Persona : PC
{

    //protected para que los hijos puedan acceder 
    protected float velocidadMov;
    protected string nombre;
    public static List<string> ListaNombre= new List<string>(){   // Ponemos static para esté solo en la clase y no se repitan en los objetos creados
        "Elias",
        "Carlos",
        "Juan",
        "Alfredo",
        "Santiago",
        "Lucas",
        "Pedro",
        "Ana",
        "Fran",
        "Manuel",
        "Bebeto"
    };

    public Persona(){
        
    }

    public string Mov_Tierra(){
        Debug.Log("Moviendo por tierra a " + velocidadMov);
        return "Moviendo por tierra a " + velocidadMov;
    }
}
