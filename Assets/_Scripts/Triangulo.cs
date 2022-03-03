using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangulo 
{
    public float lado;
    public float altura;
    private static int cantidadTriangulos = 0;

    public Triangulo(float l, float h){
        lado= l;
        altura = h;
        cantidadTriangulos++;
    }

    public float calcularArea(){
        return lado*altura/2;
    }

    public static float CalcularAreaStatic(float l, float h){
        return l*h/2;
    }

    public static int MostrarCantidad(){
        return cantidadTriangulos;
    }
}
