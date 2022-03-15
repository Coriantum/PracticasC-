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
        // Comienzan atacando los rojos, y luego azules y asi sucesivamente
        // En cada ataque se seleciona aleatoriamente cual de los 3 militares ataca
        // Gana el primero que consiga matar al aldeano


        // 1. crear 4 listas de tipo object
        /*
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

        /*
        int puntosTemporal = 10;
        for(int i=0; i<3; i++){
            militaresAzul.Add(new Militar(Persona.ListaNombre[Random.Range(0,Persona.ListaNombre.Count)],puntosTemporal));
            puntosTemporal = puntosTemporal + 10; // Por cada creacion de militar se le sumará 10 puntos de ataque
        }
             
        // El for usando la i en vez de una variable int
        for(int i=0; i<3; i++){
            militaresAzul.Add(new Militar(Persona.ListaNombre[Random.Range(0,Persona.ListaNombre.Count)],(i+1)* 10));
        } 
        */ 
        
        // 2.Asignar a los militares la accion atacar. Seleccionar aleatoriamente los 3 militares para que ataquen
        // A mayores opcion donde el que empiece a atacar sea aleatorio


        /*
            int opcion = Random.Range(0,2);

        if(opcion == 1){
            aldeanoAzul[0].SerAtacado(militaresRojo[Random.Range(0,militaresRojo.Count)].Atacar());
        }

        while(aldeanoRojo[0].EstaVivo() && aldeanoAzul[0].EstaVivo()){
            aldeanoAzul[0].SerAtacado(militaresRojo[Random.Range(0,militaresRojo.Count)].Atacar());
            if(! aldeanoAzul[0].EstaVivo()){
                Debug.Log("Ganó el rojo");
                break;
            }

            aldeanoRojo[0].SerAtacado(militaresAzul[Random.Range(0,militaresAzul.Count)].Atacar()); 
            if(! aldeanoRojo[0].EstaVivo()){
                Debug.Log("Ganó el azul");
                break;
            }
            
        }
        */

        /*
        int atacante = Random.Range(0,2);
        int defensor;
        if(atacante== 0){
            defensor = 1;
        }else{
            defensor = 0;
        }


        List<List<Aldeano>> aldeanos = new List<List<Aldeano>>();
        aldeanos.Add(aldeanoAzul);
        aldeanos.Add(aldeanoRojo);

        List<List<Militar>> militares = new List<List<Militar>>();
        militares.Add(militaresAzul);
        militares.Add(militaresRojo);
        
        while(aldeanoRojo[0].EstaVivo() && aldeanoAzul[0].EstaVivo()){
            
            if(! MilitarAtacaAldeano(militares[atacante][Random.Range(0,militaresRojo.Count)], aldeanos[defensor][0])){
                Debug.Log("Ganó el rojo");
                break;
            }

            atacante= defensor;
            if(atacante== 0){
                defensor = 1;
            }else{
                defensor = 0;
            }
            
        }

    */    


   // Ejercicio final: Crear dos listas,uno del equipo rojo y otro del azul.
    // Las listas contendrán todas las unidades de cada equipo.
    // Crea clases guerrero y arquero
    // Crea 2 aldeanos para cada equipo. Crea un edificio para cada equipo. 
    // Crea un guerrero y arquero por equipo.
    // El guerrero ataca 10 y arquero 5.
    // Hacer que uno de los 2 aleatoriamente ataque a una de las cuatro unidades aleatoriamente.
    // Si una unidad muere,se notifica,pero si ataca se pasa el turno.
    // Cada unidad de tiempo, atacará un de los dos equipos aleatoriamente.
    // Imprimir por pantalla lo que pasa y quien gana.

        

        List<Unidades> equipoRojo = new List<Unidades>(){
            new Arquero(Persona.ListaNombre[Random.Range(0,Persona.ListaNombre.Count)] + " del equipo rojo"),
            new Guerrero(Persona.ListaNombre[Random.Range(0,Persona.ListaNombre.Count)] + " del equipo rojo"),
            new Aldeano(Persona.ListaNombre[Random.Range(0,Persona.ListaNombre.Count)]+ " del equipo rojo"),
            new Aldeano(Persona.ListaNombre[Random.Range(0,Persona.ListaNombre.Count)]+ " del equipo rojo"),
            new Edificios("Casa del equipo rojo"),
        };
        
        List<Unidades> equipoAzul = new List<Unidades>(){
            new Arquero(Persona.ListaNombre[Random.Range(0,Persona.ListaNombre.Count)]+ " del equipo azul"),
            new Guerrero(Persona.ListaNombre[Random.Range(0,Persona.ListaNombre.Count)]+ " del equipo azul"),
            new Aldeano(Persona.ListaNombre[Random.Range(0,Persona.ListaNombre.Count)]+ " del equipo azul"),
            new Aldeano(Persona.ListaNombre[Random.Range(0,Persona.ListaNombre.Count)]+ " del equipo azul"),
            new Edificios("Casa del equipo azul"),
        };

        

            //((Militar) equipoRojo[Random.Range(0,2)]).Atacar(); // Se hace cast convitiendo el elemento en militar(por defecto está en unidades)

         
         // while(EstaMuerto((Militar)equipoAzul[0]) && EstaMuerto((Militar)equipoAzul[1]) && EstaMuerto((Militar)equipoRojo[0]) && EstaMuerto((Militar)equipoRojo[1]))

         // Opcion 2: Si estan todos muertos
         // while(! TodosMuertos(equipoRojo) && ! TodosMuertos(equipoAzul))

        int opcion;
        while(! TodosMuertos(equipoRojo) && ! TodosMuertos(equipoAzul)){ // Condicion: Que no estén muertos los militares

            opcion = Random.Range(0,2); // Variable que contenga un random. Dicho random tendrá un resultado diferente cada vez que recorra el while.
            Unidades defensa;
            Militar ataque;

            //Equipo azul es atacado si los rojos aun estan vivos. Se ejecutará en caso de que la variable opcion sea la indicada 
            if(opcion == 1){
                defensa = equipoAzul[Random.Range(0,equipoAzul.Count)];
                ataque = ((Militar) equipoRojo[Random.Range(0,2)]);

                //equipoAzul[Random.Range(0,equipoAzul.Count)].SerAtacado(((Militar) equipoRojo[Random.Range(0,2)]).Atacar()); Otra opcion
            }           
            //Equipo rojo es atacado si los azules estan vivos
            else{
                defensa = equipoRojo[Random.Range(0,equipoAzul.Count)];
                ataque = ((Militar) equipoAzul[Random.Range(0,2)]);
            }
            defensa.SerAtacado(ataque.Atacar());          
            
        }

        //Equipo azul            
            // Si mueren militares azules gana equipo rojo
            if(! equipoAzul[0].EstaVivo() && ! equipoAzul[1].EstaVivo()){
                Debug.Log("Ha ganado el equipo rojo");
            }

            // Equipo Rojo         
            // Si mueren militares rojos gana equipo azul
            if(! equipoRojo[1].EstaVivo() && ! equipoRojo[2].EstaVivo()){
                Debug.Log("Ha ganado el equipo azul");
            }


    }

    // Creacion de metodo donde se sepa si militares están muertos
    private bool EstaMuerto(Militar m){
        return m.EstaVivo();    
    }

    // Metodo bool todos muertos
    private bool TodosMuertos(List<Unidades> u){
        foreach(Unidades utemp in u){
            if(utemp.EstaVivo()){
                return false;
            }
        }
        return true;
    }


  


   // private bool MilitarAtacaAldeano(Militar m, Aldeano a){
    //    a.SerAtacado(m.Atacar());
    //    return a.EstaVivo();

        // Otra opcion sería:
        /*
        if(! a.EstaVivo()){
            Debug.Log("Ganó el " + b);
            return false;
        }else{
            return true;
        }
        */
        
   // }

    
    
}