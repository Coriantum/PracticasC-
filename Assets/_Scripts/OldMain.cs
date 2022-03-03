using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldMain : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // Crea una clase llamada triangulo,que tenga atributo lado,
        // un metodo calcular area, 
        // e instancia dos de esas clases en el main imprimiendo por pantalla el área
        
        Triangulo tr1 = new Triangulo(5, 4);
        Triangulo tr2 = new Triangulo(6, 7);

        //Debug.Log("Area del triangulo " + tr1.calcularArea());
        //Debug.Log("Area del triangulo 2 " + tr2.calcularArea());


        // Crear metodo estatico
        float tr3 = Triangulo.CalcularAreaStatic(3, 4);
        //Debug.Log("Area del triangulo 3" + tr3);

        // Creamos variable static que se suma cuando hacemos una nueva instancia
        //Debug.Log(Triangulo.MostrarCantidad());


        // Crear 10000 triangulos de lado aleatorio, gardando os triangulos nun array
        
        float[] areas = new float[5];
        List<float> areasLista= new List<float>();
        float calculoAreaAleatoria;
        for(int i= 0; i < areas.Length; i++) {
            calculoAreaAleatoria = Triangulo.CalcularAreaStatic(Random.Range(0, 50), Random.Range(0, 50));
            areas[i]= calculoAreaAleatoria;
            areasLista.Add(calculoAreaAleatoria);
        }

        Debug.Log(areas[0]);
        Debug.Log(areas[4]);
        Debug.Log(areasLista[1]);
        Debug.Log(areasLista[3]);


        //Lista de 5 triangulos, e imprime su area

        List<Triangulo> Triangulos = new List<Triangulo>();
        for(int i= 0; i< 5; i++){
            Triangulo tr = new Triangulo(Random.Range(0,50), Random.Range(0,50));
            Triangulos.Add(tr);
        }

        foreach(Triangulo tr in Triangulos){
             Debug.Log(tr.calcularArea());
        }

        // Elimina el elemento de menor area y vuelve a imprimir
        int indexMin = Triangulos.Count + 1; // 6 triangulos
        float areaMin = 1000000;

        for(int i= 0; i< 5; i++){
            if(Triangulos[i].calcularArea() < areaMin){
                areaMin = Triangulos[i].calcularArea();
                indexMin = i;
            }
        }

    }
}
