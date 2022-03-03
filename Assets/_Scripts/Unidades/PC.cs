using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PC : Unidades
{
    private float coste;
    private List<superficie> superficiesPosibles;


}


enum superficie{
    Terra,
    Mar,
    Montanha,
    Bosque
}