using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Persona : PC
{

    //protected para que los hijos puedan acceder 
    protected float velocidadMov;
    

    public Persona(){
        
    }

    public string Mov_Tierra(){
        Debug.Log("Moviendo por tierra a " + velocidadMov);
        return "Moviendo por tierra a " + velocidadMov;
    }
}
