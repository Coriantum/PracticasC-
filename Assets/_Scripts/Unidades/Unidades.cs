using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unidades : MonoBehaviour
{
    protected float vida_total;
    protected float vida_actual;
    private Vector3 dimensiones;
    private Vector3 vision;
    protected bool viva;
    

    public string SerAtacado(int poderAtaque){
        vida_actual = vida_actual - poderAtaque;
        if(vida_actual<= 0){
            Morir();
        }
        return "Fui atacado con " + poderAtaque + "puntos";
    }

    public string Nacer(){
        viva = true;
        Debug.Log("He nacido");
        return "nací";
    }


    // Si la vida_actual = 0, destruyes el objeto
    public string Morir(){
        viva = false;
        Debug.Log("He muerto");
        return "He muerto";
    }

    public bool EstaVivo(){
        return viva;
    }

    
}
