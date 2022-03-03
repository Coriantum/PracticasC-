using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    //public List<Aldeano> aldeanos = new List<Aldeano>();

    // Start is called before the first frame update
    void Start()
    {
        //Aldeano Elias= new Aldeano();

        //Elias.trabajar();
        //Elias.Mov_Tierra();

        // Crear 10 aldeanos y que trabajen
        //for(int i=0; i<=10; i++){
            //string nombreAleatorio = Persona.ListaNombre[Random.Range(0,Persona.ListaNombre.Count)];
            //Aldeano temporal = new Aldeano(nombreAleatorio);
            //aldeanos.Add(temporal);



            //temporal.trabajar();
            //temporal.Mov_Tierra();
        //}

        //Crear un aldeano
        //string nombreAleatorio = Persona.ListaNombre[Random.Range(0,Persona.ListaNombre.Count)];
        //Aldeano victima = new Aldeano(nombreAleatorio);

        //Crear un militar
        //Militar atacante = new Militar(nombreAleatorio);

        //Hacer que el militar ataque al aldeano
        //victima.SerAtacado(atacante.Atacar());

        /*
        //Ver puntos de vida
        // Diseñar como mueren las unidades
        //Creas las funciones de vivir y morir y destruyes el objeto si no está vivo
        Debug.Log(victima.ToString());
        Debug.Log(atacante.ToString());
        for(int i= 0; i<11 ; i++){
            victima.SerAtacado(atacante.Atacar());
            Debug.Log(victima.ToString());
            if(!victima.EstaVivo()){
                victima = null;
                Debug.Log("Destruimos victima");
                break; //Salto de bucle
            }
        }
        */

        // Hay dos equipos,rojo y azul, cada equipo tiene un aldeano que recibira los ataques
        // y tres militares,el primero militar ataca 10, el segundo 20 y el tercero 30
        // En cada ataque se seleciona aleatoriamente cual de los 3 militares ataca
        // Gana el primero que consiga matar al aldeano


        // 1. crear 4 listas de tipo object

        //string nombreAleatorio = Persona.ListaNombre[Random.Range(0,Persona.ListaNombre.Count)];
        List<Aldeano> aldeanoRojo = new List<Aldeano>(){
            new Aldeano("Carlos")
        };
        List<Militar> militaresRojo = new List<Militar>(){
            new Militar(Persona.ListaNombre[Random.Range(0,Persona.ListaNombre.Count)],10),
            new Militar(Persona.ListaNombre[Random.Range(0,Persona.ListaNombre.Count)],20),
            new Militar(Persona.ListaNombre[Random.Range(0,Persona.ListaNombre.Count)],30)
            };

        List<Aldeano> aldeanoAzul = new List<Aldeano>();
        aldeanoAzul.Add(new Aldeano("Pablo"));

        List<Militar> militaresAzul= new List<Militar>();
        int puntosTemporal = 10;
        for(int i=0; i<3; i++){
            militaresAzul.Add(new Militar(Persona.ListaNombre[Random.Range(0,Persona.ListaNombre.Count)],puntosTemporal));
            puntosTemporal = puntosTemporal + 10;
        }
        
        //Establecer puntos de ataque a los militares


        

    }

}
